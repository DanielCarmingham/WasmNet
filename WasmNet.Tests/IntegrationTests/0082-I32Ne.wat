;; invoke: ne
;; expect: (i32:1)

(module
    (func (export "ne") (result i32)
        i32.const -42
        i32.const 2
        i32.ne
    )
)