# O Mistério do Caixa

Projeto educacional da turma 2B do curso Técnico em Desenvolvimento de Sistemas, desenvolvido em C# com .NET MAUI Blazor Hybrid para a disciplina Lógica e Linguagem de Programação.

## A história

Ao fim do expediente, um sistema de caixa recebeu três vendas e apresentou um total inesperado. Os registros parecem normais, mas o fechamento não corresponde ao que a equipe esperava. Sua missão é investigar o comportamento do programa usando o depurador do Visual Studio.

## Objetivo da investigação

Acompanhar a execução do cálculo, observar como os valores mudam e identificar a causa do resultado apresentado. A investigação deve ser feita antes de qualquer alteração no código.

## Pré-requisitos

- Windows 10 versão 1809 ou posterior;
- Visual Studio 2026 com a carga de trabalho **Desenvolvimento de interface do usuário de aplicativo multiplataforma do .NET**;
- SDK .NET 10 e workload .NET MAUI para Windows.

## Clonar e abrir

```powershell
git clone <URL-DO-REPOSITORIO>
cd MisterioDoCaixa
```

Abra `MisterioDoCaixa.slnx` no Visual Studio. Confirme que `MisterioDoCaixa` é o projeto de inicialização e que o destino selecionado é **Windows Machine**.

## Executar e depurar

1. Abra `MisterioDoCaixa/Services/CaixaService.cs`.
2. Pressione **F9** em uma instrução do método `CalcularTotal()` para criar um breakpoint.
3. Pressione **F5** para iniciar o aplicativo em modo Debug.
4. Clique em **Calcular Total** e aguarde o Visual Studio interromper a execução.
5. Use **F10 (Step Over)** para executar a instrução atual sem entrar nos métodos chamados.
6. Use **F11 (Step Into)** para entrar em uma chamada de método quando quiser examiná-la em detalhes.
7. Observe `venda` e `total` nas janelas **Locais**, **Autos** ou **Inspeção**.

## Entrega da atividade

Depois da investigação, faça a correção em sua própria cópia, execute novamente o aplicativo e confirme o comportamento. Entregue:

- o código corrigido;
- um breve registro explicando o que você observou durante a depuração;
- uma descrição da alteração realizada e do resultado obtido depois dela.

Não publique credenciais, pastas de compilação nem arquivos pessoais no repositório.
