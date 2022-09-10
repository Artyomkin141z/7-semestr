import { Component } from "react";

class But extends Component {
    constructor(props){
        super(props);
        this.state = {
            url: "http://localhost:3000/dates",
            dates: []
        }
        this.request();
    }
    request = () => {fetch(this.state.url)
        .then(response => {
            return response.json();
        })
        .then((data) => {
            this.setState({dates: [...data]})
            // this.state.dates = [...data];
            console.log(this.state.dates);
        })
    }
    render(){
    return(
        <div className="container">
            <button
            onClick={() => {
                let data = {
                    date: (new Date())
                }
                let url = "http://localhost:3000/dates";
                fetch(url, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json;charset=utf-8'
                    },
                    body: JSON.stringify(data)
                });
                this.request();
            }}
            >Отправить текущую дату</button>
            <div>
                {
                    this.state.dates.map(date => {
                        return(
                            <>
                                <p
                                key={date.id}
                                >{date.date}</p>
                                <button
                                onClick={() => {
                                    let url = "http://localhost:3000/dates/"+date.id;
                                    let data = {
                                        date: new Date()
                                    }
                                    fetch(url, {
                                        method: 'PUT',
                                        headers: {
                                            'Content-Type': 'application/json;charset=utf-8'
                                        },
                                        body: JSON.stringify(data)
                                    });
                                    this.request();
                                }}
                                >Обновить</button>
                                <button
                                onClick={() => {
                                    fetch(this.state.url+"/"+date.id, {
                                        method: 'DELETE',
                                    });
                                    this.request();
                                }}
                                >
                                    Удалить
                                </button>
                            </>
                        )
                    })
                }
            </div>
        </div>
    );
    }
}

export default But;