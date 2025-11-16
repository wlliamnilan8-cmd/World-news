async function carregarNoticias() {
    try {
        const resposta = await fetch("noticias.json");
        const dados = await resposta.json();

        const container = document.getElementById("noticias");
        container.innerHTML = "";

        dados.forEach(noticia => {
            const bloco = document.createElement("div");
            bloco.className = "item";

            bloco.innerHTML = `
                <img src="${noticia.imagem}" alt="Notícia">
                <h2>${noticia.titulo}</h2>
                <p>${noticia.descricao}</p>
            `;

            container.appendChild(bloco);
        });

    } catch (erro) {
        console.error("Erro ao carregar notícias:", erro);
    }
}

carregarNoticias();
