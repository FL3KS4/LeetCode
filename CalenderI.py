class MyCalendar:

    def __init__(self):
        self.books = []

    def book(self, start: int, end: int) -> bool:
        
        if len(self.books) == 0:
            self.books.append([start,end])
            return True
        else:
            for Onebook in self.books:
                if start >= Onebook[1] or end <= Onebook[0]:
                    continue
                else:
                    return False
            self.books.append([start,end]) 
                
            return True  
