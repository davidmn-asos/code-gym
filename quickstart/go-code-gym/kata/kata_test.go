package kata

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestKataSolution(t *testing.T) {
	result := Solve()
	assert.Equal(t, 0, result)
}
