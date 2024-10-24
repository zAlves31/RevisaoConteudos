import React, { useState } from 'react';
import ToDoItem from './ToDoItem';
import './App.css';

// Componente principal da aplicação
function App() {
  // Estado para armazenar a lista de tarefas
  const [tasks, setTasks] = useState([]);
  // Estado para armazenar a nova tarefa a ser adicionada
  const [newTask, setNewTask] = useState('');

  // Função para adicionar uma nova tarefa à lista
  const addTask = () => {
    // Verifica se a nova tarefa não está vazia
    if (newTask.trim()) {
      // Adiciona a nova tarefa à lista existente e limpa o campo de input
      setTasks([...tasks, newTask]);
      setNewTask('');
    }
  };

  // Função para remover uma tarefa da lista
  const removeTask = (index) => {
    // Filtra a tarefa a ser removida com base no índice
    const newTasks = tasks.filter((task, i) => i !== index);
    // Atualiza a lista de tarefas
    setTasks(newTasks);
  };

  return (
    <div className="app">
      {/* Título da página */}
      <h1>Terça-Feira, 24 de Julho</h1>
      
      {/* Campo de input para adicionar novas tarefas */}
      <div className="task-input">
        <input 
          type="text" 
          placeholder="Nova tarefa" 
          value={newTask} 
          onChange={(e) => setNewTask(e.target.value)} 
        />
        <button onClick={addTask}>Adicionar Tarefa</button>
      </div>
      
      {/* Lista de tarefas */}
      <div className="tasks-list">
        {tasks.map((task, index) => (
          <ToDoItem 
            key={index} 
            task={task} 
            removeTask={() => removeTask(index)} 
          />
        ))}
      </div>
    </div>
  );
}

export default App;
