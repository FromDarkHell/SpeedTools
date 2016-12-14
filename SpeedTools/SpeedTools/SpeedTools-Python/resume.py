import socket
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect(("localhost", 16834))
s.send("resume\r\n")
s.send("unpausegametime\r\n")