import requests
import json

def gerar_noticias():
    url = "https://gnews.io/api/v4/top-headlines?category=world&lang=pt&country=br&max=10&apikey=3cbab6e167d45f4fff4e4a3ba282ea10"

    resposta = requests.get(url)
    dados = resposta.json()

    noticias_formatadas = []

    for artigo in dados.get("articles", []):
        noticia = {
            "titulo": artigo.get("title", "Sem título"),
            "descricao": artigo.get("description", "Sem descrição"),
            "imagem": artigo.get("image", "https://upload.wikimedia.org/wikipedia/commons/1/14/No_Image_Available.jpg")
        }
        noticias_formatadas.append(noticia)

    with open("noticias.json", "w", encoding="utf-8") as arquivo:
        json.dump(noticias_formatadas, arquivo, indent=4, ensure_ascii=False)

    print("noticias.json atualizado!")

gerar_noticias()

