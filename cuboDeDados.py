from random import randint
import time
cubo = []
tempoIni = time.clock()
for i in range(2):
    camada = []
    for j in range(2):
        linha = []
        for k in range(2):
            valor = randint(1,10)
            linha.append(valor)
        camada.append(linha)
    cubo.append(camada)
tempoFim = time.clock()
print(" {} ".format(tempoFim-tempoIni))

print(cubo)