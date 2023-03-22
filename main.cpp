#include <iostream>
#include <string>

void fizzbuzz(int max = 100, int firstMult = 3, int secondMult = 5, std::string fizz = "Fizz", std::string buzz = "Buzz") {
  for(int i = 1; i < max; i++){
    std::string output = "";
    if(i % firstMult == 0){
      output = output.append(fizz);
    }
    if(i % secondMult == 0){
      output = output.append(buzz);
    }
    if(output.size() == 0){
      output = std::to_string(i);
    }

    std::cout << output << std::endl;
  }
}

int main() {
  fizzbuzz(50, 4, 9, "Cheese", "Burger");
}