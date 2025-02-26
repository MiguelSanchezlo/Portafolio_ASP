from flask import Flask, render_template, request, redirect
from pymongo import MongoClient

app = Flask(__name__)

# Conectar con MongoDB
client = MongoClient("mongodb://localhost:27017/")
db = client["ferretech"]
collection = db["encuestas"]

@app.route('/')
def principal():
    return render_template('index.html')

@app.route('/nosotros')
def nosotros():
    return render_template('nosotros.html')

@app.route('/contacto')
def contacto():
    return render_template('contacto.html')

@app.route('/encuesta')
def encuesta():
    return render_template('encuesta.html')

@app.route('/guardar_p', methods=['POST'])
def procesar_encuesta():
    if request.method == 'POST':
        datos = {
            "nombre": request.form.get('nombre'),
            "email": request.form.get('correoe'),
            "experiencia": request.form.get('experiencia'),
            "presencia_digital": request.form.get('presencia_digital'),
            "gestion_inventario": request.form.get('gestion_inventario'),
            "uso_tecnologias": request.form.get('uso_tecnologias'),
            "analizar_demanda": request.form.get('analizar_demanda'),
            "productos_vendidos": request.form.get('productos_vendidos'),
            "diferenciacion": request.form.get('diferenciacion'),
            "registro_finanzas": request.form.get('registro_finanzas')
        }

        collection.insert_one(datos)  # Guarda la encuesta en MongoDB
        return redirect('/gracias')

@app.route('/gracias')
def gracias():
    return "<h1>¡Gracias por completar la encuesta!</h1>"

if __name__ == '__main__':
    app.run(debug=True, port=5080)
