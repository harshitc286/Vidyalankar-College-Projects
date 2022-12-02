import mysql.connector as ms
import webbrowser
from email.message import EmailMessage
import ssl
import smtplib
from colorama import Fore


def create_userid():
    m = ms.connect(host="localhost", user="root",
                   password="", database="website_db")
    cur = m.cursor()

    nme = input("Enter Your Name                  : ")
    phe = int(input("Enter Your phone no          : "))
    email = input("Enter Your Vaild Email Address : ")
    user = input("Create Your Username            : ")
    paswd = input("Create Your Password           : ")
    print("")

    cur.execute(
        f'INSERT INTO userid (user_id, name, phoneno, email_id, user_paswd) VALUES ("{user}","{nme}","{phe}","{email}","{paswd}")')

    cur.execute(f"SELECT * FROM userid WHERE (phoneno) = ('{phe}')")
    data = cur.fetchall()

    for eml in data:
        print("Your Username & Password was Created")
        print(f"Username : {user}\nPassword : {paswd}")
        print("")

    email_sender = 'websitedatabase65@gmail.com'
    email_password = 'gzuhvpxabfzqvooy'
    email_receiver = f'{eml[3]}'

    subject = 'Welcome To WebsiteDB'
    body = f"""
    Dear {nme},

    Your User ID is {user},
    Your Password is {paswd},

    ThankYou For Connected With US.

    You Can Also Follow Us On
    
    Youtube Channel - https://www.youtube.com/@Tachodex010/featured 
    College Project Youtube Playlists- https://youtube.com/playlist?list=PL-JcPNIJdeRYr3-cnOBNSXRTVTJ9JOEb6
    """

    em = EmailMessage()
    em['From'] = email_sender
    em['To'] = email_receiver
    em['Subject'] = subject
    em.set_content(body)

    context = ssl.create_default_context()

    with smtplib.SMTP_SSL('smtp.gmail.com', 465, context=context) as smtp:
        smtp.login(email_sender, email_password)
        smtp.sendmail(email_sender, email_receiver, em.as_string())

    print(f"Your Username & Password Sent to a Gmail : {email}")

    m.commit()
    m.close()


def fetch_webname():
    m = ms.connect(host="localhost", user="root",
                   password="", database="website_db")
    cur = m.cursor()

    cur.execute("SELECT * FROM insert_link")
    rows = cur.fetchall()
    print("  srno", "", '|', "Website Name", '|', "   ", "Uses Of Website")

    for data in rows:
        print('-'*200)
        print('>> ', data[0], " ", '|', data[1], "   ", '|', data[3])
        print('-'*200)
        print("")

    m.commit()
    m.close()


def search_in_webname():
    m = ms.connect(host="localhost", user="root",
                   password="", database="website_db")
    cur = m.cursor()

    val1 = input("Enter Number to visit Website : ")
    cur.execute(f"SELECT * FROM insert_link WHERE (srno) = ('{val1}')")
    data = cur.fetchall()

    for row in data:
        print( ">>", row[2])
        webbrowser.open(row[2])
        print("")

    m.commit
    m.close()


def insert_link():
    m = ms.connect(host="localhost", user="root",
                   password="", database="website_db")
    cur = m.cursor()

    val1 = input("Enter Website Name : ")
    val2 = input("Enter Website link : ")
    val3 = input("Use Of Website     : ")

    cur.execute(
        f'INSERT INTO insert_link (webname, link, web_use) VALUES ("{val1}","{val2}","{val3}")')

    print("Your Website Link Was Inserted :", cur.lastrowid, val2)
    print("")

    m.commit()
    m.close()


def feed_back():
    m = ms.connect(host="localhost", user="root",
                   password="", database="website_db")
    cur = m.cursor()

    val1 = input("Enter Your Name           : ")
    val2 = input("Enter Your phone no       : ")
    val4 = input("Enter Your Valid Email ID :  ")
    val3 = input("Enter Your FeedBack       : ")

    cur.execute(
        f'INSERT INTO feed_back(phone_no, name, feedback, email_id) VALUES ("{val2}","{val1}","{val3}","{val4}")')
    cur.execute(f"SELECT * FROM feed_back WHERE (phone_no) = ('{val2}')")
    data = cur.fetchall()
    for eml in data:
        print("")
        print(
            f'Dear User {val1},\nYour Feedback is :"{eml[4]}", \nFeedBack Was Submited,\nThanks For FeedBack Us, We Improve on it.')
        print("")
    email_sender = 'websitedatabase65@gmail.com'
    email_password = 'gzuhvpxabfzqvooy'
    email_receiver = f'{eml[3]}'

    subject = 'Thanks For Feedback to WebsiteDB'
    body = f"""
    Dear {val1},
    Your FeedBack Was Submited,
    Feedback is : "{eml[4]}",

    Thanks For FeedBack Us, We Improve on it.

    ThankYou For Connected With US.

    You Can Also Follow Us On
    
    Youtube Channel - https://www.youtube.com/@Tachodex010/featured 
    College Project Youtube Playlists- https://youtube.com/playlist?list=PL-JcPNIJdeRYr3-cnOBNSXRTVTJ9JOEb6
    
    """

    em = EmailMessage()
    em['From'] = email_sender
    em['To'] = email_receiver
    em['Subject'] = subject
    em.set_content(body)

    context = ssl.create_default_context()

    with smtplib.SMTP_SSL('smtp.gmail.com', 465, context=context) as smtp:
        smtp.login(email_sender, email_password)
        smtp.sendmail(email_sender, email_receiver, em.as_string())

    m.commit()
    m.close()


ch = 'y'
while ch == 'y':

    print()
    print(Fore.RED+"******************************WELCOME*******************************")
    print("")
    print(Fore.YELLOW+"1. Create Your User ID in WebsiteDB")
    print("2. To View Amazing Websites")
    print("3. Search Into Website type int")
    print("4. Insert Your Link (You Think to add this websiteDB)")
    print("5. Your FeedBack, To improve this")
    print("")

    choice = int(input(Fore.WHITE+"Enter Your Choice : "))

    print("")
    if choice == 1:
        create_userid()
    elif choice == 2:
        fetch_webname()
    elif choice == 3:
        search_in_webname()
    elif choice == 4:
        insert_link()
    elif choice == 5:
        feed_back()

    ch = input("Wish To Continue Type (y/n) : ")
