def fizzbuzz (fizz, buzz, cap, word1, word2):
  for i in range(cap):
    output = ""
    for j in fizz:
      if i % j == 0:
        output = output + word1
        break
    for j in buzz:
      if i % j == 0:
        output = output + word2
        break
    if output == "":
      output = str(i)
    print(output)
  return

#fizzbuzz([3], [5], 100, "fizz", "buzz")
fizzbuzz([3, 11], [5, 7], 100, "ThreeEleven", "FiveSeven")