-- From: http://stackoverflow.com/q/4541415
-- Modified so that 1 is not prime
isPrime 1 = False
isPrime x = null $ filter divisible $ takeWhile notTooBig [2..] 
    where
        divisible y = x `mod` y == 0
        notTooBig y = y * y <= x

-- Naieve prime generator        
primes = [ n | n <- [ 1.. ], isPrime n ]


