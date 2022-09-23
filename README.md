# Cronômetro via console usando .NET e C#

- Opções: Minuto ou segundo, futuramente adicionar opção de escolha para contagem crescente ou decrescente
- Métodos: Foi utilizado ao método ToLower() para tornar a string digitada minuscula, após isso o método Substring()
para pegar parte da string digitada para realizar a separação do tempo e do tipo, com isso saber se o usuário deseja
contar em segundos ou minutos, ex: 10s ou 10m.
Além disso também foi utilizado os Métodos Thread e Sleep para fazer com que a execução atual do programa durma/espere
por determinado tempo ex: espere 2s e faça algo.
