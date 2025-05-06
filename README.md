# ⚡ Sistema de Monitoramento – Módulo 3

![Plataforma](https://img.shields.io/badge/plataforma-Windows-blue.svg)
![Linguagem](https://img.shields.io/badge/C%23-8.0-green.svg)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow.svg)
![Licença](https://img.shields.io/badge/licen%C3%A7a-Acad%C3%AAmica-lightgrey.svg)

🎓 Projeto acadêmico desenvolvido como parte da disciplina de **Sistemas em Tempo Real (STR)** no curso de Engenharia de Computação da **UFU** – Universidade Federal de Uberlândia.

---

## 📌 Descrição Geral

O **Módulo 3** deste sistema supervisório é responsável pelo monitoramento visual das medições realizadas por dispositivos de medição (IEDs) em plantas elétricas. Ele recebe, interpreta e exibe em tempo real:

- Séries históricas de corrente e tensão
- Eventos de proteção (Módulo 2)
- Eventos filtrados (Módulo 4)
- Eventos complexos (Módulo 5)

🖥️ A interface gráfica é projetada conforme as diretrizes da norma **ISA-101**.

---

## 🎯 Objetivos

- 📊 Monitorar grandezas elétricas (tensões e correntes)
- ⚠️ Exibir eventos de proteção e anomalias em tempo real
- 🔍 Facilitar a análise histórica com gráficos dinâmicos
- 🤝 Integrar dados oriundos de múltiplos módulos
- 📡 Receber pacotes via **UDP** em formato **JSON**

---

## 🧰 Tecnologias Utilizadas

| Tecnologia        | Versão     |
|-------------------|------------|
| C#                | 8.0        |
| .NET Core         | 3.1+       |
| Windows Forms / WPF | Interface |
| Protocolo         | UDP        |
| Formato de Dados  | JSON       |

---

## 🖼️ Interface Gráfica

A interface exibe:

- 📈 Gráficos com medições em tempo real
- 🔴 Indicadores visuais para eventos ativos
- 🧩 Agrupamento por IEDs monitorados

> 📌 Interface baseada na norma ISA-101 para consistência visual em sistemas supervisórios.

---

## 📡 Comunicação

- Recebimento de pacotes via **UDP broadcasting** em rede local (VLAN)
- Processamento de dados em **tempo real**
- Interpretação de mensagens em **JSON**

---

## 🛠️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/sistema-monitoramento-modulo3.git
2. Abra no Visual Studio (versão compatível com C# 8);
3. Compile e execute;
4. Certifique-se de que a rede esteja recebendo os pacotes UDP esperados.

---

## 📁 Estrutura do Projeto
📦 SistemaMonitoramentoSE<br>
 ┣ 📂 SistemaMonitoramentoSE<br>
 ┃ ┣ 📂 Assets &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Pasta com recursos gráficos<br> 
 ┃ ┣ 📂 Controllers &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Pasta com recursos para manipulação na base de dados<br> 
 ┃ ┣ 📂 Handlers &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Pasta com recursos para manipulação na conexão com o SWITCH e recebimento dos pacotes UDP<br> 
 ┃ ┣ 📂 Models &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Pasta com recursos para o mapeamento com as entidades na base de dados<br> 
 ┃ ┣ 📜 DBConnection.cs &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Arquivo para realizar a conexão com a base de dados<br> 
 ┃ ┣ 📜 Program.cs &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Arquivo principal para a inicialização do Winforms<br> 
 ┃ ┣ 📜 Form1 &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Formulário principal <br> 
 ┃ ┣ 📜 Form2 &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Formulário secundário <br> 
 ┃ ┣ 📜 Form3 &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Formulário secundário<br> 
 ┃ ┣ 📜 Form4 &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;# Formulário secundário<br>
 ┗ 📜README.md               

---

## 👨‍🔬 Equipe
-  👨‍💻 Adão Fidélis Justino Neto - 12311ECP025
-  👨‍💻 Gustavo Alves de Oliveira - 12311ECP026
-  🧑‍🏫 Prof. Alan Petrônio Ribeiro - UFU/LRI
	
---

## 🚨 Review
> O professor orientou aos alunos a refatoração do projeto, para algo semelhante a um supervisório de subestações elétricas, de modo a apresentar os gráficos de modo concomitante das Unidades de Medições, bem como a geração de eventos e alertas com a característica de, realmente, chamar a atenção.

### ✉️ Contato
- 📧 Gustavo Alves de Oliveira<br>
- 📱 (34) 99636-2512<br>
- 📬 gustavo.oliveira7@ufu.br<br>

