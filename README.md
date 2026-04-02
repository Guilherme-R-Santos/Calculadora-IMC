# 🧮 Calculadora de IMC

<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:43cea2,100:185a9d&height=180&section=header&text=Calculadora%20de%20IMC&fontSize=36&fontColor=ffffff" alt="Banner Calculadora de IMC" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8" />
  <img src="https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C# 12" />
  <img src="https://img.shields.io/badge/Tipo-Console-blue?style=for-the-badge" alt="Aplicação Console" />
</p>

Projeto de console em `C#` para cálculo de **IMC (Índice de Massa Corporal)** e exibição do **estado nutricional** com base no resultado.

> ⚠️ Este projeto possui finalidade **educacional/ilustrativa** e não substitui avaliação médica ou nutricional.

---

## ✨ O que este projeto faz

- Solicita ao usuário:
  - Peso (kg)
  - Altura (m)
  - Idade
  - Sexo (`M` ou `F`)
- Calcula o IMC com a fórmula:

```text
IMC = peso / (altura × altura)
```

- Retorna o valor formatado com duas casas decimais.
- Informa a classificação nutricional.

---

## 📊 Faixas de classificação utilizadas

| IMC | Classificação |
|---|---|
| `< 16` | Magreza grau III |
| `16 a 16,99` | Magreza grau II |
| `17 a 18,49` | Magreza grau I |
| `18,5 a 24,99` | Eutrofia |
| `25 a 29,99` | Sobrepeso |
| `30 a 34,99` | Obesidade Grau I |
| `35 a 39,99` | Obesidade Grau II |
| `>= 40` | Obesidade Grau III |

---

## 🚀 Como executar

### Pré-requisitos

- SDK do `.NET 8` instalado

### Passos

```bash
dotnet restore
dotnet run
```

---

## 🧪 Exemplo de uso

```text
Calculadora de IMC (Índice de Massa Corporal)
Por favor, insira o seu peso em quilogramas:
70
Agora, insira a sua altura em metros:
1,75
Insira a sua idade:
28
Por fim, insira o seu sexo (M para masculino, F para feminino):
M
Seu IMC é: 22,86
Seu estado nutricional é: Eutrofia
```

---

## 🧱 Estrutura do projeto

```text
Calculadora-IMC/
├── Program.cs
└── README.md
```

---

<p align="center">
  Feito com <strong>C#</strong>, <strong>.NET</strong> e um toque de 🩺
</p>
