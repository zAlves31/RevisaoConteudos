import React from 'react';
import './App.css';

// Componente para representar cada item da lista de tarefas
function ToDoItem({ task, removeTask }) {
  return (
    <div className="task-item">
      {/* Exibe o texto da tarefa */}
      <span>{task}</span>
      {/* Botão para remover a tarefa */}
      <button onClick={removeTask}>Excluir</button>
    </div>
  );
}

export default ToDoItem;
