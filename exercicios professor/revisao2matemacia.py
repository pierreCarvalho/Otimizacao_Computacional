 vetor = [1,2,3,4,5,6,7,8,9]
vetorUsuario = []
for i in range(len(vetor))
    vetorUsuario.append(int(input("Digite um valor inteiro")))
op = input("Digite a operação: soma,sub,mult,div: ")
for i in range(len(vetor))
    if op == 'soma':
        vetor[i] = vetor[i] +vetorUsuario[i]
    elif op == 'sub':
        vetor[i] = vetor[i] - vetorUsuario[i]
    elif op == 'mult':
        vetor[i] = vetor[i]  * vetorUsuario[i]
    elif op == 'div':
        vetor[i] = vetor[i]  / vetorUsuario[i]
print(vetor)