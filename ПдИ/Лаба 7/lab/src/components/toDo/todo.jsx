import styles from "./styles.module.css";
import add from "../../image/add.png"

import Task from "./task/task";
import { Component } from "react";

class Todo extends Component {
    constructor(props){
        super(props);
        this.state = {
            tasks: [],
            task: "",
        }
    }
    render(){
        
        return(
            <div className="container">
                <div className={styles.todo}>
                    <h1>Список задач</h1>
                    <div className={styles.tasks}>
                        {this.state.tasks.map((task) => {
                            return <Task 
                                task = {task}
                            />;
                        })}   
                    </div>
                    <div className={styles.add}>
                        <input type="text"
                        onChange={(e) => {
                            this.setState({task: e.target.value})
                        }}
                        ></input>
                        <img src={add} alt="img"
                        onClick={() => {
                            this.setState({tasks: [...this.state.tasks, this.state.task]})
                            console.log(this.state.tasks);
                        }}
                        />
                    </div>
                </div>
            </div>
        );
    }
}

export default Todo;