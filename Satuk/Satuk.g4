grammar Satuk;

//(arithmetics | print | logical)* ;

program: class* functions* 'program' LBRACE prog return RBRACE;

prog:   (assignment | if_statement | loop | print | execute_function)*;

LPAREN     : '(';
RPAREN     : ')';
LBRACE     : '{';
RBRACE     : '}';
LBRACK     : '[';
RBRACK     : ']';
SEMICOLON  : ';';
COMMA      : ',';
DOT        : '.';

ASSIGN         : '=';
GT             : '>';
LT             : '<';
NOT            : '!';
QUESTION       : '?';
EQUAL          : '==';
LE             : '<=';
GE             : '>=';
NOTEQUAL       : '!='|'=!';
AND            : '&&';
OR             : '||';
INC            : '++';
DEC            : '--';
ADD            : '+';
SUB            : '-';
MUL            : '*';
DIV            : '/';
MOD            : '%';
ADD_ASSIGN     : '+=';
SUB_ASSIGN     : '-=';
MUL_ASSIGN     : '*=';
DIV_ASSIGN     : '/=';
WS: [ \t\r\n]+ -> skip;

INT     : [0-9]+;
STRING  : '"'[a-zA-Z0-9_ ]+'"';
BOOL    : 'true' | 'false';
FLOAT   : ('0' ',' [0-9]+ | [1-9][0-9]* ',' [0-9]*) | ('0' ',' [0-9]*);
CHAR    : '\''[a-zA-Z0-9]'\'';
VARIABLE : [a-zA-Z]+[0-9]*;


assignment: (assign_char | assign_string | assign_float_constant | assign_bool | assign_int_ar | assign_int_constant | assign_float_ar | assign_bool_logical | assignment_class | assign_bool_dynamic | assign_char_dynamic | assign_float_dynamic | assign_int_dynamic | assign_string_dynamic | assignment_function) SEMICOLON;

assign_bool: 'bool' VARIABLE (ASSIGN BOOL)? #boolAss;

assign_bool_logical: VARIABLE ASSIGN expr=logical_instructions #boolLogAss;

assign_bool_dynamic: VARIABLE ASSIGN BOOL #boolDynAss;

assign_string: 'string' VARIABLE (ASSIGN STRING)? #stringAss;

assign_string_dynamic: VARIABLE ASSIGN STRING #stringDynAss;

assign_char: 'char' VARIABLE (ASSIGN CHAR)? #charAss;

assign_char_dynamic: VARIABLE ASSIGN CHAR #charDynAss;

assign_int_constant: 'int' VARIABLE (ASSIGN INT)? #intConstAss;

assign_int_ar: VARIABLE ASSIGN expr=arithmetics_int #intArAss;

assign_int_dynamic: VARIABLE ASSIGN INT #intDynAss;

assign_float_constant: 'float' VARIABLE (ASSIGN FLOAT)? #floatConstAss;

assign_float_dynamic: VARIABLE ASSIGN FLOAT #floatDynAss;

assign_float_ar: VARIABLE ASSIGN expr=arithmetics_float #floatArAss;

assignment_class: VARIABLE VARIABLE (ASSIGN 'new' VARIABLE LPAREN ((VARIABLE | FLOAT | INT | STRING | CHAR | BOOL) (COMMA (VARIABLE | FLOAT | INT | STRING | CHAR | BOOL))*)* RPAREN)? #classAss;


assignment_function: ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE)? VARIABLE ASSIGN execute_function;



arithmetics

        : left=arithmetics op=(MUL | DIV | MOD) right=arithmetics       #opArithm
        | left=arithmetics op=(ADD | SUB) right=arithmetics     #opArithm
        | LPAREN arithmetics RPAREN     #parenArithm
        | (INT | FLOAT | VARIABLE) #numberArithm;

arithmetics_int: (INT | VARIABLE) (( ADD | SUB | MUL | DIV | MOD | ADD_ASSIGN | SUB_ASSIGN | MUL_ASSIGN | DIV_ASSIGN) (INT | VARIABLE))+ #opArithmInt;

arithmetics_float: (FLOAT | VARIABLE) (( ADD | SUB | MUL | DIV | MOD | ADD_ASSIGN | SUB_ASSIGN | MUL_ASSIGN | DIV_ASSIGN) (FLOAT | VARIABLE))+ #opArithmFloat;

mutators: int_inc | float_inc | int_dec | float_dec | variable_inc | variable_dec;

int_inc: INT INC SEMICOLON? #incInt;
float_inc: FLOAT INC SEMICOLON? #incFloat;
int_dec: INT DEC SEMICOLON? #decInt;
float_dec: FLOAT DEC SEMICOLON? #decFloat;
variable_inc: VARIABLE INC SEMICOLON? #incVar;
variable_dec: VARIABLE DEC SEMICOLON? #decVar;


logical_instructions: logical_bool | logical_numeric | logical_text | logical_var;

logical_bool: NOT? BOOL ((NOTEQUAL | EQUAL) BOOL)? ((OR | AND) logical_instructions)* #logBool;

logical_numeric: (FLOAT | INT | VARIABLE) (LE | GE | LT | GT | EQUAL | NOTEQUAL) (FLOAT | INT | VARIABLE)  ((OR | AND) logical_instructions)* #logNum;

logical_text: (STRING | CHAR) (EQUAL | NOTEQUAL) (STRING | CHAR) ((OR | AND) logical_instructions)* #logText;

logical_var: NOT? VARIABLE ((LE | GE | LT | GT | EQUAL | NOTEQUAL) VARIABLE)? ((OR | AND) logical_instructions)* #logVar;



if_statement: 'if' LPAREN logical_instructions RPAREN LBRACE prog RBRACE ('else if' LPAREN logical_instructions RPAREN LBRACE prog RBRACE)* ('else' LBRACE prog RBRACE)?;

loop: 'loop' LPAREN logical_instructions RPAREN LBRACE prog RBRACE;

print: 'display' LPAREN result=print_content RPAREN SEMICOLON #display;

print_content : (arithmetics | logical_instructions | VARIABLE | STRING | CHAR | INT | FLOAT | BOOL);


functions: function | constructor;

function: void_function | int_function | float_function | string_function | char_function | bool_function | variable_function;

constructor: VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog RBRACE #construct;


return: void_return | int_return | float_return | string_return | char_return | bool_return | variable_return;

class: 'class' VARIABLE LBRACE (assignment | functions)* RBRACE;

execute_function: (VARIABLE DOT)* VARIABLE LPAREN ((VARIABLE | FLOAT | INT | STRING | CHAR | BOOL) (COMMA (VARIABLE | FLOAT | INT | STRING | CHAR | BOOL))*)* RPAREN SEMICOLON;

void_function: 'void' VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog void_return RBRACE #funcVoid;
int_function: 'int' VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog int_return RBRACE #funcInt;
float_function: 'float' VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog float_return RBRACE #funcFloat;
string_function: 'string' VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog string_return RBRACE #funcString;
char_function: 'char' VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog char_return RBRACE #funcChar;
bool_function: 'bool' VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog bool_return RBRACE #funcBool;
variable_function: VARIABLE VARIABLE LPAREN (('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE (COMMA ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE) VARIABLE)*)* RPAREN LBRACE prog variable_return RBRACE #funcVar;

void_return: 'return' SEMICOLON;
int_return: 'return' (INT | VARIABLE | arithmetics_int | int_inc | int_dec) SEMICOLON #retInt;
float_return: 'return' (FLOAT | VARIABLE | arithmetics_float | float_inc | float_dec)SEMICOLON #retFloat;
string_return: 'return' (STRING | VARIABLE) SEMICOLON #retString;
char_return: 'return' (CHAR | VARIABLE) SEMICOLON #retChar;
bool_return: 'return' (BOOL | VARIABLE | logical_instructions) SEMICOLON #retBool;
variable_return: 'return' VARIABLE SEMICOLON #retVar;