from flask import Flask


app = Flask(__name__)

@app.route('/') # GET - по умолчанию
def main():
    return '<h1>HELLO, WORLD!</H1>'

@app.route('/info') # GET - по умолчанию
def info():
    return '<h1>Меня создала компания GekkBrains</H1>'

@app.route('/summa/<x>/<y>') # GET - по умолчанию
def summa(x, y):
    return f'<h1>{x} + {y} = {int(x) + int(y)}</h2>'

if __name__ == '__main__':
    app.run(port=8080)