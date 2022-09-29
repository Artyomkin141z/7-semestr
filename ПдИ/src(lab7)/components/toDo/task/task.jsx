import styles from "./styles.module.css";
import trash from "../../../image/trash.png";
import { Component } from "react";

class Task extends Component{
    constructor(props){
        super(props);
        this.state = {
            isActive: false,
        }
    }
    returnStyle = (isActive) => {
        if(isActive) return styles.task + " " + styles.active
        else return styles.task;
    }
    render(){
    return(
        <div className={this.returnStyle(this.state.isActive)}>
            <div>
                <input type="checkbox"
                onChange={() => {
                    this.setState({isActive: !this.state.isActive});
                    // console.log(this.state.isActive);
                }}
                />
                <p>{this.props.task}</p>
            </div>
            <img className={styles.delete} src={trash} alt="trash"
                onClick={() => {
                    this.props.deleteTask(this.props.index);
                }}
            />    
        </div>
    ); 
    }
}

export default Task;