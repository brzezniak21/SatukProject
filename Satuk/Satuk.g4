grammar Satuk;

program: 'program' LBRACE prog RBRACE;

prog:   (assignment | if | loop | print | mutators)*;

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
        | 'string' VARIABLE (ASSIGN STRING)? SEMICOLON #stringAss
        | 'char' VARIABLE (ASSIGN CHAR)? SEMICOLON #charAss
        | 'int' VARIABLE (ASSIGN expr=arithmetics)? SEMICOLON #intConstAss
        | VARIABLE ASSIGN (INT | FLOAT | BOOL | STRING | CHAR)  SEMICOLON #varDynAss
        | 'float' VARIABLE (ASSIGN expr=arithmetics)? SEMICOLON #floatConstAss
        | VARIABLE VARIABLE (ASSIGN 'new' VARIABLE LPAREN ((VARIABLE | FLOAT | INT | STRING | CHAR | BOOL) (COMMA (VARIABLE | FLOAT | INT | STRING | CHAR | BOOL))*)* RPAREN)? #classAss;



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


if: if_statement;

if_statement: 'if' LPAREN ifcondition = logical_instructions RPAREN LBRACE ifprog = prog  RBRACE elif = elif_statement? else = else_statement? #ifStatement;
elif_statement: 'else if' LPAREN elifcondition=logical_instructions RPAREN LBRACE elifprog = prog RBRACE elif=elif_statement? #elifStatement;
else_statement: 'else' LBRACE elseprog = prog RBRACE #elseStatement;


loop: 'loop' LPAREN loopcondition=logical_instructions RPAREN LBRACE loopprog=prog RBRACE #loopStatement;





