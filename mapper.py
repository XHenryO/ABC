import sys

for line in sys.stdin:
    line = line.strip()
    parts = line.split()
    if len(parts) > 3:
        status_code = parts[3]
        if 400 <= int(status_code) <= 499:
            print(f"{parts[0]}\t1")