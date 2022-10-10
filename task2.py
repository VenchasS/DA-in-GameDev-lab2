import gspread
import numpy as np
# define data, and change list to array
x = [3,21,22,34,54,34,55,67,89,99]
x = np.array(x)
y = [2,22,24,65,79,82,55,130,150,199]
y = np.array(y)

def model(a,b,x):
    return a*x + b

def loss_function(a,b,x,y):
    num = len(x)
    prediction = model(a,b,x)
    return (0.5 / num) * (np.square(prediction - y)).sum()

def optimize(a,b,x,y):
    num = len(x)
    prediction = model(a,b,x)
    da = (1.0 / num) * ((prediction -y)*x).sum()
    db = (1.0 / num) * ((prediction -y).sum())
    a = a - Lr*da
    b = b - Lr*db
    return a,b

def iterate(a,b,x,y,times):
    for i in range(times):
        a,b = optimize(a,b,x,y)
    return a,b

gc = gspread.service_account(filename="unitypythonsheets-7664ce31a9fc.json")
sh = gc.open("unitysheets")
def Send(i: int, a,b,loss):
    sh.sheet1.update("A" + str(i), str(a))
    sh.sheet1.update("B" + str(i), str(b))
    sh.sheet1.update("C" + str(i), str(loss))
    print(a,b,loss)


a = np.random.rand(1)
b = np.random.rand(1)
Lr = 0.000001


a,b = iterate(a,b,x,y,1)
prediction = model(a,b,x)
loss = loss_function(a,b,x,y)
Send(1,a,b,loss)

a,b = iterate(a,b,x,y,10)
prediction = model(a,b,x)
loss = loss_function(a,b,x,y)
Send(2,a,b,loss)

a,b = iterate(a,b,x,y,100)
prediction = model(a,b,x)
loss = loss_function(a,b,x,y)
Send(3,a,b,loss)

a,b = iterate(a,b,x,y,1000)
prediction = model(a,b,x)
loss = loss_function(a,b,x,y)
Send(4,a,b,loss)