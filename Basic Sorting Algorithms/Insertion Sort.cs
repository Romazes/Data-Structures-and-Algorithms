public void InsertionSort() { 
  int inner, temp; 
  for(int outer = 1; outer <= upper; outer++) { 
    temp = arr[outer]; 
    inner = outer; 
    while(inner > 0 && arr[inner-1] >= temp) { 
      arr[inner] = arr[inner-1]; 
      inner -= 1; 
    } 
    arr[inner] = temp; 
  } 
}
