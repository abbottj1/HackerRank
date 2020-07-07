package main

import (
	"reflect"
	"testing"
)

func Test_maxSubarray(t *testing.T) {
	type args struct {
		arr []int32
	}
	tests := []struct {
		name string
		args args
		want []int32
	}{
		{
			name: "3.1",
			args: args{
				arr: []int32{1, 2, 3, 4},
			},
			want: []int32{10, 10},
		},
		{
			name: "3.2",
			args: args{
				arr: []int32{2, -1, 2, 3, 4, -5},
			},
			want: []int32{10, 11},
		},
		{
			name: "4.1",
			args: args{
				arr: []int32{-2, -3, -1, -4, -6},
			},
			want: []int32{-1, -1},
		},
	}
	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			if got := maxSubarray(tt.args.arr); !reflect.DeepEqual(got, tt.want) {
				t.Errorf("maxSubarray() = %v, want %v", got, tt.want)
			}
		})
	}
}
