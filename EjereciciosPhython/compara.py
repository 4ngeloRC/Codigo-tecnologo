import os
os.system("cls")

def ingresar_numero(mensaje):
    while True:
        numero = input(mensaje)
        if numero.replace('.', '', 1).isdigit() or (numero[0] == '-' and numero[1:].replace('.', '', 1).isdigit()):
            return int(numero)
        else:
            print("Error: Debes ingresar un número válido.")

def encontrar_intermedio(num1, num2, num3):
    if num1 >= num2 and num1 >= num3:
        mayor = num1
        if num2 >= num3:
            menor = num3
            intermedio = num2
        else:
            menor = num2
            intermedio = num3
    elif num2 >= num1 and num2 >= num3:
        mayor = num2
        if num1 >= num3:
            menor = num3
            intermedio = num1
        else:
            menor = num1
            intermedio = num3
    else:
        mayor = num3
        if num1 >= num2:
            menor = num2
            intermedio = num1
        else:
            menor = num1
            intermedio = num2
    return menor, intermedio, mayor

numero1 = ingresar_numero("Ingrese el primer número: ")
numero2 = ingresar_numero("Ingrese el segundo número: ")
numero3 = ingresar_numero("Ingrese el tercer número: ")

menor, intermedio, mayor = encontrar_intermedio(numero1, numero2, numero3)

print("El número menor es:", menor)
print("El número intermedio es:", intermedio)
print("El número mayor es:", mayor)