## Environment Variables

*Following is the partial list of important environment variables. These variables are set and accessed as mentioned below:*


1. DISPLAY
   - Contains the identifier for the display that X11 programs should use by default.

2. HOME
   - Indicates the home directory of the current user: the default argument for the cd built-in command.

3. IFS
   - Indicates the Internal Field Separator that is used by the parser for word splitting after expansion.

4. LANG
   - LANG expands to the default system locale; LC_ALL can be used to override this. For example, if its value is pt_BR, then the language is set to (Brazilian) Portuguese and the locale to Brazil.

5. LD_LIBRARY_PATH
   - A Unix system with a dynamic linker, contains a colonseparated list of directories that the dynamic linker should search for shared objects when building a process image after exec, before searching in any other directories.

6. PATH
   - Indicates the search path for commands. It is a colon-separated list of directories in which the shell looks for commands.

7. PWD
   - Indicates the current working directory as set by the cd command.

8. RANDOM
   - Generates a random integer between 0 and 32,767 each time it is referenced.

9. SHLVL
   - Increments by one each time an instance of bash is started. This variable is useful for determining whether the built-in exit command ends the current session.

10. TERM
    - Refers to the display type.

11. TZ
    - Refers to Time zone. It can take values like GMT, AST, etc.

12. UID
    - Expands to the numeric user ID of the current user, initialized at the shell startup.

[Unix / Linux - Environment](https://www.tutorialspoint.com/unix/unix-environment.htm)