public void BubbleSort() {
  int temp;
  for(int outer = upper; outer >= 1; outer--) {
    for(int inner = 0; inner <= outer - 1; inner++)
      if((int)arr[inner] > arr[inner+1]){
        temp = arr[inner];
        arr[inner] = arr[inner+1];
        arr[inner+1] = temp;
      }
  }
}
