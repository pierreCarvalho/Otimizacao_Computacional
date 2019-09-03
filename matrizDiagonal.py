arquivo = open('sistema.txt','r')
texto = arquivo.readlines()

def testarDiagonal(matriz):
    
    linha = len(matriz)
    coluna = len(matriz[0])


    for l in range(linha):
        
        for c in range(coluna):

            if l == c and matriz[l][c] != 1:
                valorDiagonal = matriz[l][c]
                
                print("essa diagonal não é 1")
                x = 0

                while(x < 3):
                   matriz[l][x] = matriz[l][x] / valorDiagonal
                   x = x+1
    
    return matriz

def exibirMatriz(matriz):

    for linha in matriz:
        print(linha)

'''
matriz = [[3,2,3],[1,1,3],[4,5,6]]
print("Matriz antes de testar a diagonal: ")
exibirMatriz(matriz)

matriz = testarDiagonal(matriz)
print("Matriz depois de testar a diagonal: ")
exibirMatriz(matriz)
'''

matriz_1 = []
linha = []
parte1 = texto[0].rstrip()
print(parte1)

parte2 = texto[1].rstrip()
print(parte2)

parte3 = texto[2].rstrip()
print(parte3)
for i in range(len(parte1)):
    
    print(parte1[i])
    if parte1[i] == 'x':
        print("É x")
        linha.append(1)
    if parte1[i] == 'y':
        print("É y")
        linha.append(1)
    if parte1[i] == 'z':
        print("É z")
        linha.append(1)

print(linha)






#print(len(texto))