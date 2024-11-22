# Test Plan for Functional Testing (User Registration and Login)
### 1. Objective
To ensure that the user registration and login functionalities of the NFT marketplace work as intended, providing users with secure, smooth, and error-free access to their accounts.
### 2. Scope
- Registration process for new users.
- Login functionality for existing users.
- Interaction with Metamask
- Error handling and validation during registration and login.
### 3. Test Environment
- **Platform**: Web (desktop and mobile browsers)
- **Browsers**: Chrome
- **Devices**: Desktop and mobile
- **Operating Systems**: Windows, macOS, iOS, Android.
### 4. Test Data Requirements
- Valid Metamask Wallet
- Test cases for special characters, empty fields, and different boundaries.
### 5. Entry Criteria
- The user registration and login modules have been developed and deployed in the test environment.
- Necessary APIs and database connections are functional.
- Test environment is set up and ready for testing.
### 6. Exit Criteria
- All test cases related to registration and login are executed.
- High-severity bugs are fixed and re-tested.
- Test reports and logs are reviewed.
### 7. Test Cases
**Test Case 1: Register with Valid Details**
- **Steps**: Navigate to the registration page, enter through Metamask
- **Expected Result**: User account is created, and user ahs possibility to interact with application

**Test Case 2: Register with an Already Connected Metamask**
- **Steps**: Try registering with an email that’s already in use.
- **Expected Result**: An error message like “Email already in use” is displayed.

**Test Case 3: Register with Invalid Metamask
- **Steps**: Connect not existed Metamask Wallet
- **Expected Result**: An error message like “Invalid Metamask” is displayed.

**Test Case 4: Login with Account Lockout After Multiple Failed Attempts**
- **Steps**: Attempt to log in with incorrect credentials multiple times (e.g., 5).
- **Expected Result**: User account is temporarily locked, with a message like “Too many failed attempts. Please try again later.”

**Test Case 5: Metamask Reset Functionality**
- **Steps**: Navigate to the "Reset Metamask" page, connect new or reset existed.
- **Expected Result**: A Metamask reset with further possibilities.
### 8. Pass/Fail Criteria
- A test case passes if the actual result matches the expected result.
- A test case fails if there are deviations from the expected result.
### 9. Bug Reporting
- All failures are logged in the bug tracking system (Obsidian) with detailed information about the steps to reproduce, severity, and relevant screenshots/logs.
