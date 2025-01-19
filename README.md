# Exploring-Security-Vulnerabilities-Designing-an-Insecure-Login-System-for-Educational-Purposes
The objective of this project is to create a login system with a specific vulnerability: it checks whether the username and password exist in the database but does not verify if they correspond to the same user. While retaining this flaw as a demonstration, we also implement additional measures to prevent other vulnerabilities, making the system secure in other aspects.

Why Focus on an Insecure Login System?

Insecure login systems are a common attack vector, exploited frequently in real-world scenarios. By studying such vulnerabilities, learners can:

Understand the critical importance of secure authentication mechanisms.

Recognize the devastating impact of logical flaws in authentication.

Learn how to implement mitigations for other common vulnerabilities, such as brute-force attacks.

The Core Vulnerability

In a secure authentication system, the username and password must not only exist in the database but also match for the same user. In our deliberately flawed system, the system checks:

Whether the username exists in the database.

Whether the password exists in the database.

However, it does not verify that the username and password belong to the same user. This design flaw can result in unauthorized access when a valid username is paired with another user's password.

System Design

This insecure login system is built using Visual Basic. Below are the core features of the system:

Database Simulation: A static list of users containing usernames and passwords is used to simulate a database.

Authentication Flaw: The system checks if the username and password exist independently, but does not validate their relationship.

Security Measures: To enhance the learning experience, we add protections against other vulnerabilities, such as brute-force attacks.

Here’s a high-level overview of the design:
- Users try to log in by providing their username and password.
- The system checks if the username exists in the database.
- The system checks if the password exists in the database.
- If both checks pass, the login is deemed successful, regardless of whether the username and password belong to the same user.

Security Enhancements

While the primary vulnerability remains intact for educational purposes, we’ve implemented the following measures to protect against other attacks:

Brute-Force Protection:

Users are locked out for 5 minutes after 3 failed login attempts from the same IP address.

Input Validation:

The code ensures that requests are properly parsed and necessary fields are checked.

Hashing in Password Reset:

Passwords are hashed during resets to demonstrate proper handling of sensitive data.

Exploitation of the Vulnerability

To exploit the vulnerability:

Use a valid username, such as admin.

Use a password associated with another user, such as password123.

The system will allow access, even though the username and password do not match.

This demonstrates the dangers of neglecting to validate the relationship between authentication credentials.

Lessons Learned

Authentication Logic Matters: Always ensure that username-password pairs are validated together.

Defense in Depth: Implement additional measures, such as brute-force protection, to mitigate other attack vectors.

Hands-On Practice: Simulating vulnerabilities in a controlled environment is invaluable for understanding real-world risks.

Conclusion

By designing this insecure login system, we’ve highlighted how small oversights in authentication logic can lead to significant security risks. For students and developers, this project is an excellent opportunity to think like an attacker, identify weaknesses, and improve their secure coding practices.
