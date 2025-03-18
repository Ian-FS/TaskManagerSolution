# Task Manager API ✅

Este projeto foi desenvolvido como um desafio prático na **Rocketseat**, com o objetivo de construir uma **API RESTful** para gerenciamento de tarefas. O sistema permite a criação, visualização, edição e exclusão de tarefas, seguindo uma **arquitetura em camadas**.

## 🚀 Funcionalidades

- Criar uma tarefa
- Visualizar todas as tarefas
- Visualizar uma tarefa específica pelo ID
- Editar informações de uma tarefa
- Excluir uma tarefa

## 📡 Endpoints

- **POST** `/tasks` - Criar uma tarefa
- **GET** `/tasks` - Listar todas as tarefas
- **GET** `/tasks/{id}` - Buscar uma tarefa pelo ID
- **PUT** `/tasks/{id}` - Editar uma tarefa
- **DELETE** `/tasks/{id}` - Deletar uma tarefa

## 🛠️ Estrutura dos Dados

Cada tarefa possui os seguintes atributos:
- `id` (int): Identificador único da tarefa.
- `name` (string): Nome da tarefa.
- `description` (string): Descrição da tarefa.
- `priority` (string): Define a prioridade da tarefa (`high`, `medium`, `low`).
- `deadLine` (int): Data limite para a realização da tarefa.
- `status` (string): Status da tarefa (`completed`, `processing`, `pending`).

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core 8 API (Somente rotas, não inclui banco de dados)
- Arquitetura em camadas (Camada de Comunicação e Camada de Regras de Negócio)
