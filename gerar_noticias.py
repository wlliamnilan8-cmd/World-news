import requests
import json
import os

API_KEY = os.environ.get("NEWSDATA_API_KEY")

URL = "https://newsdata.io/api/1/news"

params = {
    "apikey": API_KEY,
    "country": "br",
    "language": "pt",
    "category": "top",
}

def fetch_news():
    response = requests.get(URL, params=params)
    data = response.json()

    # Se a API retornar erro
    if "results" not in data:
        return {
            "error": True,
            "message": data.get("message", "Erro desconhecido"),
            "data": data
        }

    return data["results"]

def save_news():
    noticias = fetch_news()

    with open("noticias.json", "w", encoding="utf-8") as f:
        json.dump(noticias, f, indent=4, ensure_ascii=False)

    print("Arquivo noticias.json atualizado com sucesso!")

if __name__ == "__main__":
    save_news()
