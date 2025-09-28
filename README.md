# Desafio de Projeto: Abstraindo um Celular com POO em C#

Projeto de laboratório da trilha **.NET** da **Digital Innovation One (DIO)**, concluído em 27 de Setembro de 2025.

## 📖 Sobre o Desafio

O objetivo deste projeto foi aplicar na prática os pilares da **Programação Orientada a Objetos (POO)** para criar um sistema simples que abstrai as funcionalidades de um celular.

A tarefa consistiu em modelar uma classe `Smartphone` como um modelo **abstrato**, contendo propriedades e métodos comuns a qualquer celular. A partir dela, foram criadas classes filhas (`Nokia` e `Iphone`) que herdam essas características e implementam seus próprios comportamentos específicos, como a instalação de aplicativos, através da sobrescrita de métodos (`override`).

## 🚀 Conceitos e Tecnologias Aplicadas

* **Linguagem:** C#
* **Plataforma:** .NET
* **Paradigma:** Programação Orientada a Objetos (POO)
* **Pilares da POO:**
    * **Abstração:** Definição de uma entidade base (`Smartphone`) com características essenciais.
    * **Herança:** Criação de classes específicas que herdam de uma classe base.
    * **Polimorfismo:** Sobrescrita de métodos para que cada classe filha tenha um comportamento único.
    * **Encapsulamento:** Agrupamento de propriedades e métodos dentro de uma classe.

## 📚 Jornada de Aprendizagem

Para a construção deste projeto, foi necessário absorver o conhecimento de diversos módulos e cursos focados em C# e no paradigma de Orientação a Objetos. A base de conhecimento para este desafio incluiu:

* Introdução, Abstração e Encapsulamento com C#
* Herança e Polimorfismo com C#
* Classes Abstratas e Interfaces com C#
* Propriedades, Métodos e Construtores com C#
* Exceções e Coleções com C#
* Manipulando Valores com C#
* Tuplas, Operador Ternário e Desconstrução de um Objeto com C#
* Nuget, Serializar e Atributos no C#

## 🛠️ Como Executar

```bash
# 1. Clone o repositório
git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)

# 2. Navegue até a pasta do projeto
cd seu-repositorio

# 3. Execute a aplicação
dotnet run
