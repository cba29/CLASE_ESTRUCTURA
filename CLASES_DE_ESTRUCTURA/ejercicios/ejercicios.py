def main():
    print("BIENVENIDO")

    # Solicitar al usuario que ingrese el primer n�mero
    numero1 = float(input("Ingresa el primer numero: "))

    # Solicitar al usuario que ingrese el segundo n�mero
    numero2 = float(input("Ingresa el segundo numero: "))

    # Realizar las operaciones
    suma = numero1 + numero2
    resta = numero1 - numero2
    multiplicacion = numero1 * numero2

    # Verificar si el segundo n�mero es cero antes de la divisi�n
    if numero2 != 0:
        division = numero1 / numero2
    else:
        print("No se puede dividir por cero.")
        division = None

    # Mostrar los resultados
    print("Suma:", suma)
    print("Resta:", resta)
    print("Multiplicaci�n:", multiplicacion)
    if division is not None:
        print("Divisi�n:", division)

if __name__ == "__main__":
    main()


