# Gestão Financeira

Sistema de Gestão financiera, aplica conceitos de arquitetura de Microsserviços e Orientação a Eventos, juntamente com a segregação de domínios "Lançamentos" e "Fluxo de Caixa".

Em Lançamentos é realizado cadastro e gestão de operações financeiras ocorridas diariamente na companhia. Os registros cadastrados são publicados em fila RabbitMq para consumo de domínios interessados nas informações geradas.

No domínio de Fluxo de Caixa é direcionado a consulta de relatórios que disponibilize o saldo diário consolidado de todos as movimentações realizadas, estas informações são consumidas através da fila RabbitMq de Lançamento.

Segue a visão do desenho arquitetura proposto:

![image](./Arquitetura%20Proposta.gif "Arquitetura do sistema de Gestão Financeira")

## Escolha de arquitetura

Esta arquitetura foi estruturada para possibilitar escalabilidade e resiliência entre os domínios, assim cada domínio, com seu próprio conjunto de elementos operem de forma independente.
Através de filas em RabbitMq os eventos propagados, através por contratos pré-definidos, proporcionando baixo aclopamento entre os domínios.  

## Execução de projetos

>[!Atenção]
>
>Os projetos de frontend e backend utilizam docker para facilitar os projetos de execução dos projetos, por conta disso garanta que o mesmo esteja instalado em sua estação de trabalho para execução correta dos containers.

## Migration

Para registrar novas migrations, execute o seguinte comando:

``dotnet ef --startup-project ..\Lancamentos.Api\Lancamentos.Api.csproj --project .\Lancamentos.Data.csproj migrations add {descricao}``

Após execute comando para executar todos os comandos:


``dotnet ef --startup-project ..\contatos.web\contatos.web.csproj --project .\contatos.infra.csproj database update``


#### Execução de testes unitários

