fd:"234567890JQKA" cross "DCHS"
count fd
-52?fd
-7?fd

shuffled:-52?fd

p1_face_down:3 sublist shuffled
p2_face_down:3 3 sublist shuffled

p1_face_up:6 3 sublist shuffled
p2_face_up:9 3 sublist shuffled

p1:12 3 sublist shuffled
p2:15 3 sublist shuffled

pool_size:-18+count fd 
pool:(-1*pool_size) sublist shuffled
