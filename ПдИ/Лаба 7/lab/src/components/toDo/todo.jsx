import styles from "./styles.module.css";
import add from "../../image/add.png"

import Task from "./task/task";
import { Component } from "react";

class Todo extends Component {
    constructor(props){
        super(props);
        this.keyID = 1;
        this.state = {
            tasks: [],
            task: "",
        }
    }
    deleteTask = (index) => {
        // console.log("index: ", index);
        this.state.tasks.splice(index, 1)
        this.setState({tasks: this.state.tasks});
        // console.log(this.state.tasks);
    }
    render(){ 
        return(
            <div className="container">
                <div className={styles.todo}>
                    <h1>Список задач</h1>
                    <div className={styles.tasks}>
                        {this.state.tasks.map((task, index) => {
                            return <Task 
                                key={task.key}
                                task = {task.title}
                                index = {index}
                                deleteTask = {this.deleteTask}
                            />;
                        })}   
                    </div>
                    <form className={styles.add}
                        onSubmit={(e) => {
                            e.preventDefault();
                            this.keyID++;
                            this.setState({tasks: [...this.state.tasks, 
                                {'key': this.keyID, 'title': this.state.task}]
                                });
                            e.target.reset();
                        }}
                    >
                        <input type="text"
                        onChange={(e) => {
                            this.setState({task: e.target.value})
                        }}
                        ></input>
                        <img src={add} alt="img"
                        onClick={(e) => {
                            this.keyID++;
                            this.setState({tasks: [...this.state.tasks, 
                                {'key': this.keyID, 'title': this.state.task}]
                                });                      
                        }}
                        />
                    </form>
                </div>
            </div>
        );
    }
}

export default Todo;