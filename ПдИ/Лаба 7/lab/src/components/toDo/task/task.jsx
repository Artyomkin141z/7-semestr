import styles from "./styles.module.css";
import trash from "../../../image/trash.png";

function Task(props){
    return(
        <div className={styles.task}>
            <div>
                <input type="checkbox"/>
                <p>{props.task}</p>
            </div>
            <img className={styles.delete} src={trash} alt="trash"/>
        </div>
    ); 
}

export default Task;