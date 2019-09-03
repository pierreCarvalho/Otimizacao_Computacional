def problema1(lista,lista2,operacao):
    vetor_tmp = []
    for i in range(len(lista)):
        if operacao == '+': 
            vetor_tmp.append(lista[i] + lista2[i])
        elif operacao == '-':
            vetor_tmp.append(lista[i] - lista2[i])
        elif operacao == '*':
            vetor_tmp.append(lista[i] * lista2[i])
        elif operacao == '/':
            vetor_tmp.append(lista[i] / lista2[i])   
    return vetor_tmp
v = [1,2,3,4,5]
v2 = []
print(v)
for i in range(len(v)):
    i = int(input("Digite um valor"))
    v2.append(i)
print(v2)
op = input('Digite a operação + ou - ou * ou / :')
v3 = problema1(v,v2,op)
print(v3)