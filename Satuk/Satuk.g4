grammar Satuk;

//(arithmetics | print | logical)* ;

program: class* functions* 'program' LBRACE prog return RBRACE;

prog:   (assignment | if_statement | loop | print | execute_function | mutators)*;

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
STRING  : '"'[a-zA-Z0-9_+-/*%>=<|&!?: ]+'"';
BOOL    : 'true' | 'false';
FLOAT   : ('0' ',' [0-9]+ | [1-9][0-9]* ',' [0-9]*) | ('0' ',' [0-9]*);
CHAR    : '\''[a-zA-Z0-9]'\'';
VARIABLE : [a-zA-Z]+[0-9]*;

print: 'display' LPAREN result=print_content RPAREN SEMICOLON #display;

print_content 

    : STRING #displayString
    | VARIABLE #print_variable
    | CHAR #print_char
    | INT #print_int
    | FLOAT #print_float
    | BOOL #print_bool 
    | arithmetics #print_arithmetics
    | logical_instructions #print_logicalInstructions;

assignment
        :VARIABLE ASSIGN expr=arithmetics SEMICOLON #ArAss

        | 'bool' VARIABLE (ASSIGN expr=logical_instructions)? SEMICOLON #boolAss
 //       | VARIABLE ASSIGN expr=logical_instructions SEMICOLON #boolLogAss
        | 'string' VARIABLE (ASSIGN STRING)? SEMICOLON #stringAss
        | 'char' VARIABLE (ASSIGN CHAR)? SEMICOLON #charAss
        | 'int' VARIABLE (ASSIGN expr=arithmetics)? SEMICOLON #intConstAss
        | VARIABLE ASSIGN (INT | FLOAT | BOOL | STRING | CHAR)  SEMICOLON #varDynAss
        | 'float' VARIABLE (ASSIGN expr=arithmetics)? SEMICOLON #floatConstAss
        | VARIABLE VARIABLE (ASSIGN 'new' VARIABLE LPAREN ((VARIABLE | FLOAT | INT | STRING | CHAR | BOOL) (COMMA (VARIABLE | FLOAT | INT | STRING | CHAR | BOOL))*)* RPAREN)? #classAss;


assignment_function: ('string' | 'char' | 'int' | 'float' | 'bool' | VARIABLE)? VARIABLE ASSIGN execute_function;



arithmetics

        : left=arithmetics op=(MUL | DIV | MOD) right=arithmetics       #opArithm
        | left=arithmetics op=(ADD | SUB) right=arithmetics     #opArithm
        | LPAREN arithmetics RPAREN     #parenArithm
        | (INT | FLOAT | VARIABLE) #numberArithm;

mutators
    : VARIABLE INC SEMICOLON? #incVar
    | VARIABLE DEC SEMICOLON? #decVar;


logical_instructions
    : NOT expr=logical_instructions #notLogical
    | left = logical_instructions op = (LE | GE | LT | GT | EQUAL | NOTEQUAL) right = logical_instructions #opLogical
    | left = logical_instructions op = (OR | AND) right = logical_instructions #opLogical
    | (FLOAT | INT | VARIABLE | BOOL | VARIABLE | arithmetics) #varLogical;



if_statement: 'if' LPAREN logical_instructions RPAREN LBRACE prog RBRACE ('else if' LPAREN logical_instructions RPAREN LBRACE prog RBRACE)* ('else' LBRACE prog RBRACE)?;

loop: 'loop' LPAREN logical_instructions RPAREN LBRACE prog RBRACE;


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
int_return: 'return' (INT | VARIABLE | arithmetics ) SEMICOLON #retInt;
float_return: 'return' (FLOAT | VARIABLE | arithmetics )SEMICOLON #retFloat;
string_return: 'return' (STRING | VARIABLE) SEMICOLON #retString;
char_return: 'return' (CHAR | VARIABLE) SEMICOLON #retChar;
bool_return: 'return' (BOOL | VARIABLE | logical_instructions) SEMICOLON #retBool;
variable_return: 'return' VARIABLE SEMICOLON #retVar;