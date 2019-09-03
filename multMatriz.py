from random import randint
def gerarMatriz(tamanho):
    matriz = []
    for i in range(tamanho):
        linha = []
        for j in range(tamanho):
            valor = randint(1,10)
            linha.append(valor)
        matriz.append(linha)
    return matriz
def multiplicar(matriz_1,matriz_2):
    resultado = []
    for i in range(len(matriz_1)):
        resultado.append([])
        for j in range(len(matriz_1)):
            resultado[i].append(0)
            for k in range(len(matriz_1)):
                resultado[i][j] += matriz_1[i][k] * matriz_2[k][j]
    print(resultado)
tamanho = int(input("informe o  tamanho da matriz:"))
matriz_1 = gerarMatriz(tamanho)
matriz_2 = gerarMatriz(tamanho)

print(matriz_1)
print(matriz_2)

matriz_resultante = multiplicar(matriz_1,matriz_2)
print(matriz_resultante)




