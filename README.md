# Projeto de Automação de Testes - Multiplas Linguagens e Frameworks

Este projeto demonstra a integração e aplicação de diversas linguagens de programação e frameworks de automação de testes. O objetivo principal é cobrir diferentes cenários de testes, tanto para APIs quanto para aplicações web, usando ferramentas como **Python**, **Java**, **C#** e **JavaScript**.

## Tecnologias Utilizadas

### 1. Python - Pytest
- **Pytest** é um framework popular para testes unitários e de integração em Python.
- Utilizamos **Pytest** para criar e gerenciar casos de teste em APIs e funcionalidades backend.

### 2. Java - Testes com Selenium
- **Selenium** é um framework amplamente utilizado para automação de testes em navegadores.
- Através de **Java**, os testes foram desenvolvidos para validar funcionalidades de UI, garantindo que os elementos do frontend estejam funcionando conforme o esperado.
  
### 3. C# - Automação Backend
- Em **C#**, realizamos testes unitários e de integração utilizando o **MSTest** para validar a lógica de negócio do backend, garantindo a estabilidade e qualidade das funcionalidades do sistema.
  
### 4. JavaScript - WebdriverIO
- **WebdriverIO (WDIO)** é um framework para automação de testes de aplicações web.
- Utilizando **JavaScript** e o WDIO, foram desenvolvidos testes de automação E2E para garantir que todo o fluxo de navegação e funcionalidade da interface gráfica esteja de acordo com os requisitos.

## Estrutura do Projeto

```bash
.
├── pytest-tests/         # Testes automatizados usando Pytest (Python)
├── selenium-java/        # Testes de UI usando Selenium com Java
├── csharp-tests/         # Testes de backend usando MSTest em C#
└── wdio-tests/           # Testes end-to-end usando WebdriverIO com JavaScript

