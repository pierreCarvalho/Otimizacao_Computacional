def mostra(lista):
    for vlr in range(len(lista)):
        print(lista[vlr])


v = [1,2,3,5,7,9]
valor = int(input("Digite o valor a aplicar no vetor:"))
sinal = input("Digite o sinal a aplicar: (+ ou -):")
for i in range(len(v)):
    if sinal == "+":
        v[i] = v[i]+valor
    else:
        v[i] = v[i]-valor

mostra(v)