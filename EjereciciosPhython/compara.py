import os
os.system("cls")
def encontrar_intermedio(num1, num2, num3):
    numeros = [num1, num2, num3]
    numeros.sort()
    menor = numeros[0]
    intermedio = numeros[1]
    mayor = numeros[2]
    return menor, intermedio, mayor

numero1 = int(input("Ingrese el primer número: "))
numero2 = int(input("Ingrese el segundo número: "))
numero3 = int(input("Ingrese el tercer número: "))

menor, intermedio, mayor = encontrar_intermedio(numero1, numero2, numero3)

print("El número menor es:", menor)
print("El número intermedio es:", intermedio)
print("El número mayor es:", mayor)