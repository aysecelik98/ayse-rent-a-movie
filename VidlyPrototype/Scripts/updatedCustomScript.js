document.addEventListener("DOMContentLoaded", () => {

    //Get Headlines
    const apiKey = "66e755c3affb4bc89b9efba642987c70";
    const newsUrl = `https://newsapi.org/v2/top-headlines?category=technology&country=us&apiKey=${apiKey}`;


    //GetArticles();
    axios.get(newsUrl)
        .then((resp) => dataHandler(resp.data.articles))
        .catch((err) => console.log(err));

    function dataHandler(data) {
        const article = {
            'title': [],
            'url': []
        };

        data.forEach(function (value, key) {
            setTimeout(function () {
                article.title.push(value['title']);
                article.url.push(value['url']);

                const feeds = document.querySelector(".display-feeds");
                feeds.setAttribute("href", article.url[key]);
                feeds.textContent = article.title[key];

            }, key * 5000);
            
        });

        
    }

});