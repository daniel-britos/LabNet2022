const sending = () => {
    let nicks = $('#nickname').val();
    let data = {
        type: "GET",
        url: `https://api.giphy.com/v1/gifs/search?api_key=uOzNt4S1zh2ZqlIy1tzwx3JkZkf2dggG&q=${nicks}`,
        data: {
            "data": [],
            "pagination": {
                "total_count": 0,
                "count": 0,
                "offset": 0
            },
            "meta": {
                "status": 200,
                "msg": "OK",
                "response_id": "go1iedohmaws011q5pjsiz7wjycs30ijcfnq16qg"
            }
        },
        dataType: "json",
        success: (response) => {
            $('#container > *').remove('#stilish');
            for (i of response.data) {
                $('#container').append(`
                <div id="stilish">
                    <img id="imageRef" src="${i.images.downsized_large.url}">
                    <div id="detail">
                        <p>TITLE: ${i.title}</p>
                        <p>TYPE: ${i.type}</p>   
                        <a href="${i.url}">URL</a>
                    </div>
                </div>
                `);
            }
        },
        error: () => {
            console.log('Error..');
        }
    };
    $.ajax(data);
}
