# 📇 LiteApp v1.0

**LiteApp** é um aplicativo simples e intuitivo para cadastro e gerenciamento de contatos, desenvolvido em **C#** com **Windows Forms**, voltado para aprendizado e aplicação prática de conceitos básicos de programação desktop.

---

## 🧠 Funcionalidades

- Adicionar novo contato com nome e telefone
- Listar contatos cadastrados em tempo real
- Limpar campos de entrada rapidamente
- Interface gráfica amigável para iniciantes

---

## 🛠️ Tecnologias Utilizadas

- 💻 **C#**
- 🪟 **Windows Forms (.NET Framework)**
- 📁 Persistência em memória *(versão v1.0)*

---

## 📂 Estrutura do Projeto

LiteAppSolution/
│
├── LiteApp.UI/ # Interface gráfica (WinForms)
│ └── Form1.cs # Formulário principal
│
├── LiteApp.Domain/ # (Planejado) Modelos de dados
├── LiteApp.Data/ # (Planejado) Persistência em arquivos ou banco
└── README.md # Este arquivo

---

## ▶️ Como Executar

1. Abra a solução `LiteAppSolution.sln` no **Visual Studio**
2. Compile o projeto com `Ctrl + Shift + B` ou menu `Build > Build Solution`
3. Pressione `F5` para executar
4. Use os campos "Nome" e "Telefone" para adicionar contatos

---

## 📦 Como Gerar o Executável

1. No Visual Studio, altere o modo de build para `Release`
2. Compile novamente
3. Vá até a pasta: `LiteApp.UI\bin\Release\`
4. O arquivo `LiteApp.UI.exe` estará pronto para uso

---

## 📌 Próximas Versões

| Versão | Funcionalidade prevista                   |
|--------|-------------------------------------------|
| v1.1   | Salvamento e leitura de contatos em JSON  |
| v1.2   | Edição e exclusão de contatos             |
| v1.3   | Tela de login                             |
| v2.0   | Integração com banco de dados (SQLite)    |

---

## 🧑‍💻 Autor

**Nathan Mesquita**  
Desenvolvedor iniciante focado em C# com Visual Studio  

---

## 📃 Licença

Este projeto está sob a licença MIT.  
Sinta-se livre para usar, estudar e modificar o código como desejar.
