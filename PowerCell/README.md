``` mermaid
classDiagram
class Cell {
    -charge: float 
    -Name: string
    -Charge: float
    -Level: int
    +Consume(float)void
    +Restore()void
    +ToString()override
}
```