# bubblesort py
# compara elementos adjacentes e os troca de posição se estiverem na ordem errada
# O(n^2)
def bubble_sort(a):
    for i in range(len(a)):
        for j in range(0, len(a)-i-1):
            if a[j] > a[j+1]:
                a[j], a[j+1] = a[j+1], a[j]
                
# selection sort
# encontra o menor elemento e o coloca no início
# O(n^2)
def selection_sort(a):
    for i in range(0, len(a)):
        min = i
        for j in range(i+1, len(a)):
            if a[j] < a[min]:
                min = j
        a[i], a[min] = a[min], a[i]

# insertion sort
# percorre a lista e insere cada elemento na posição correta
# O(n^2)
def insertion_sort(a):
    for i in range(1, len(a)):
        j = i
        while j > 0 and a[j-1] > a[j]:
            a[j], a[j-1] = a[j-1], a[j]

# merge sort
# divide a lista em duas metades, ordena cada metade e depois junta
# O(n log n)
def merge_sort(a):
    if len(a) <= 1:
        return a
    mid = len(a) // 2
    left = a[:mid]
    right = a[mid:]
    left = merge_sort(left)
    right = merge_sort(right)
    return merge(left, right)

# quick sort
# escolhe um elemento como pivô e divide a lista em duas partes
# O(n log n)
def quick_sort(a):
    if len(a) <= 1:
        return a
    pivot = a[len(a) // 2]
    left = [x for x in a if x < pivot]
    middle = [x for x in a if x == pivot]
    right = [x for x in a if x > pivot]
    return quick_sort(left) + middle + quick_sort(right)

# heap sort
# cria uma árvore binária e a transforma em heap
# O(n log n)
def heapify(a, n, i):
    largest = i
    l = 2 * i + 1
    r = 2 * i + 2
    if l < n and a[i] < a[l]:
        largest = l
    if r < n and a[largest] < a[r]:
        largest = r
    if largest != i:
        a[i], a[largest] = a[largest], a[i]
        heapify(a, n, largest)