# 🧪 UserService - Unit Testing Demo with MSTest

This project demonstrates how to implement and test core functionalities in a simple user management service using **C#** and **MSTest**.

## 📌 Project Overview

The `UserService` class is a basic utility designed to:

- Add new users
- Retrieve users by name

Each function includes input validation and business logic, making it ideal for showcasing **unit testing principles**.

## ✅ Why These Functions?

### 1. `AddUser(string name, string email)`

This function simulates a real-world scenario of registering or storing users. It includes:

- Input validation (non-empty name and email)
- Uniqueness check (prevents duplicate users by name)

🧠 **Why it's great for testing:**
- You can test **valid inputs**, **duplicate detection**, and **invalid data**.
- It demonstrates how to test for both **expected behavior** and **exceptions**.

---

### 2. `FindUserByName(string name)`

This function retrieves a user object based on the provided name (case-insensitive). It helps simulate common operations like search or lookup in a database or service.

🧠 **Why it's great for testing:**
- You can test return values when:
  - The user **exists**
  - The user **does not exist**
- It reinforces testing of **null returns**, **search behavior**, and **string comparison** logic.

---

## 🧪 Unit Tests Included

We use **MSTest** to cover:

- ✅ Successful user addition
- ❌ Duplicate user handling
- ❌ Invalid input (empty name/email)
- 🔍 Finding existing users
- 🔍 Handling non-existent users gracefully

This showcases:
- Positive and negative test cases
- Exception testing
- Assertion best practices

---

## 🚀 How to Run the Tests

Make sure you have the .NET SDK installed.

```bash
dotnet test --logger "trx"
```

## ✅ CI/CD with GitHub Actions

This project uses automated testing via GitHub Actions to ensure code quality and prevent regressions.

### 🔄 Workflow Steps

* **Trigger:** Runs automatically on every `push` to the `main` branch and on every `pull_request` targeting the `main` branch.
* **Build:** Restores all necessary dependencies and compiles the C# code using the `dotnet build` command.
* **Test:** Executes all unit test suites found within the solution using the `dotnet test` command with the MSTest framework.
* **Result:**
    * **✅ Passing tests → PR mergeable.** If all tests pass, the pull request is considered safe to merge into the `main` branch.
    * **❌ Failing tests → Blocks merge (if branch protection enabled).** If any tests fail, the GitHub Actions workflow will report a failure, and if branch protection rules are configured on the `main` branch, the pull request will be blocked from being merged until the issues are resolved and all tests pass.

### Example CI Scenario

```bash
git checkout -b feature/email-validation
# Make changes...
git add .
git commit -m "Add email format validation"
git push origin feature/email-validation
➡️ GitHub runs tests automatically and reports status in the PR.