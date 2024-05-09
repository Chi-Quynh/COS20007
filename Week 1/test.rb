
def average(numbers)
    total = 0
    count = 0
  
    numbers.each do |num|
      total += num
      count += 1
    end
  
    average = total.to_f / count
    return average
  end
  

numbers = [5, 10, 15, 20, 25]
result = average(numbers)
puts "Average: #{result}"

numbers = [5, 10, 15, 20, 25]
result = average(numbers)

if result >= 10
  puts "Double digits"
else
  puts "Single digits"
end


