namespace Maple2.Trigger._99999900 {
    public static class _massive00 {
        public class State재생버튼 : TriggerState {
            internal State재생버튼(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999900__MASSIVE00__0$", arg3: 3000);
                context.SetEventUI(arg1: 1, script: "$99999900__MASSIVE00__1$", arg3: 5000, arg4: "0");
                context.SetTimer(id: "1001", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State중지버튼(context);
                }

                if (context.UserDetected(arg1: new[] {900})) {
                    return new State일부Pattern시작(context);
                }

                if (context.UserDetected(arg1: new[] {902})) {
                    return new State모든Pattern순차시작(context);
                }

                if (context.UserDetected(arg1: new[] {903})) {
                    return new State모든PatternRandom시작(context);
                }

                if (context.TimeExpired(arg1: "1001")) {
                    return new State재생버튼(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1001");
            }
        }

        private class State일부Pattern시작 : TriggerState {
            internal State일부Pattern시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "퍼즐패턴45,퍼즐패턴46,퍼즐패턴47,퍼즐패턴48,퍼즐패턴49,퍼즐패턴50,퍼즐패턴51,퍼즐패턴52,퍼즐패턴53,퍼즐패턴54,퍼즐패턴55,퍼즐패턴56,퍼즐패턴57,퍼즐패턴58,퍼즐패턴59,퍼즐패턴60", arg3: false);
                context.ShowCountUI(text: "$99999900__MASSIVE00__2$", stage: 1, count: 5);
                context.SetTimer(id: "1002", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1002")) {
                    return new State퍼즐단계(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1002");
            }
        }

        private class State모든Pattern순차시작 : TriggerState {
            internal State모든Pattern순차시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "퍼즐패턴10,퍼즐패턴11,퍼즐패턴12,퍼즐패턴13,퍼즐패턴14,퍼즐패턴15,퍼즐패턴16,퍼즐패턴17,퍼즐패턴18,퍼즐패턴19,퍼즐패턴20,퍼즐패턴21,퍼즐패턴22,퍼즐패턴23,퍼즐패턴24,퍼즐패턴25,퍼즐패턴26,퍼즐패턴27,퍼즐패턴28,퍼즐패턴29,퍼즐패턴30,퍼즐패턴31,퍼즐패턴32,퍼즐패턴33,퍼즐패턴34,퍼즐패턴35,퍼즐패턴36,퍼즐패턴37,퍼즐패턴38,퍼즐패턴39,퍼즐패턴40,퍼즐패턴41,퍼즐패턴42,퍼즐패턴43,퍼즐패턴44,퍼즐패턴45,퍼즐패턴46,퍼즐패턴47,퍼즐패턴48,퍼즐패턴49,퍼즐패턴50,퍼즐패턴51,퍼즐패턴52,퍼즐패턴53,퍼즐패턴54,퍼즐패턴55,퍼즐패턴56,퍼즐패턴57,퍼즐패턴58,퍼즐패턴59,퍼즐패턴60", arg3: false);
                context.ShowCountUI(text: "$99999900__MASSIVE00__3$", stage: 1, count: 5);
                context.SetTimer(id: "1003", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1003")) {
                    return new State퍼즐단계(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1003");
            }
        }

        private class State모든PatternRandom시작 : TriggerState {
            internal State모든PatternRandom시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "퍼즐패턴10,퍼즐패턴11,퍼즐패턴12,퍼즐패턴13,퍼즐패턴14,퍼즐패턴15,퍼즐패턴16,퍼즐패턴17,퍼즐패턴18,퍼즐패턴19,퍼즐패턴20,퍼즐패턴21,퍼즐패턴22,퍼즐패턴23,퍼즐패턴24,퍼즐패턴25,퍼즐패턴26,퍼즐패턴27,퍼즐패턴28,퍼즐패턴29,퍼즐패턴30,퍼즐패턴31,퍼즐패턴32,퍼즐패턴33,퍼즐패턴34,퍼즐패턴35,퍼즐패턴36,퍼즐패턴37,퍼즐패턴38,퍼즐패턴39,퍼즐패턴40,퍼즐패턴41,퍼즐패턴42,퍼즐패턴43,퍼즐패턴44,퍼즐패턴45,퍼즐패턴46,퍼즐패턴47,퍼즐패턴48,퍼즐패턴49,퍼즐패턴50,퍼즐패턴51,퍼즐패턴52,퍼즐패턴53,퍼즐패턴54,퍼즐패턴55,퍼즐패턴56,퍼즐패턴57,퍼즐패턴58,퍼즐패턴59,퍼즐패턴60", arg3: true);
                context.ShowCountUI(text: "$99999900__MASSIVE00__4$", stage: 1, count: 5);
                context.SetTimer(id: "1004", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1004")) {
                    return new State퍼즐단계(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1004");
            }
        }

        private class State퍼즐단계Wait : TriggerState {
            internal State퍼즐단계Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1005", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$99999900__MASSIVE00__5$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1005")) {
                    return new State퍼즐단계(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1005");
            }
        }

        private class State퍼즐단계 : TriggerState {
            internal State퍼즐단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true);
                context.SetTimer(id: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State퍼즐단계정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "99");
            }
        }

        private class State퍼즐단계정리 : TriggerState {
            internal State퍼즐단계정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계종료(context);
                }

                if (context.UserDetected(arg1: new[] {901})) {
                    return new State중지버튼(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1");
            }
        }

        private class State퍼즐단계종료 : TriggerState {
            internal State퍼즐단계종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999900__MASSIVE00__6$", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {901})) {
                    return new State퍼즐단계Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중지버튼 : TriggerState {
            internal State중지버튼(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999900__MASSIVE00__7$", arg3: 5000);
                context.SetTimer(id: "1000", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1000")) {
                    return new State재생버튼(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "1000");
            }
        }

        private class State퍼즐Pattern10 : TriggerState {
            internal State퍼즐Pattern10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern11 : TriggerState {
            internal State퍼즐Pattern11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22, 23, 24, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 34, 35, 36, 37, 47, 57, 67, 66, 65, 64, 54, 44}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern12 : TriggerState {
            internal State퍼즐Pattern12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 31, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 60, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 71, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 100}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern13 : TriggerState {
            internal State퍼즐Pattern13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern14 : TriggerState {
            internal State퍼즐Pattern14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern15 : TriggerState {
            internal State퍼즐Pattern15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {23, 24, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {45, 46, 55, 56}, arg2: false, arg3: 5600, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern16 : TriggerState {
            internal State퍼즐Pattern16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 89, 78, 67, 56, 45, 34, 23, 12, 11, 21, 31, 41, 51, 61, 71, 81, 83, 84, 85, 86, 87, 88, 90, 80, 70, 60, 50, 40, 30, 20, 18, 17, 16, 15, 14, 13, 22, 32, 42, 52, 62, 72, 74, 75, 76, 77, 79, 69, 59, 49, 39, 29, 27, 26, 25, 24}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern17 : TriggerState {
            internal State퍼즐Pattern17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 18, 17, 16, 15, 14, 13, 12, 11, 21, 31, 41, 51, 61, 71, 81, 83, 84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 29, 27, 26, 25, 24, 23, 22, 32, 42, 52, 62, 72, 74, 75, 76, 77, 78, 68, 58, 48, 38, 36, 35, 34, 33, 43, 53, 63, 65, 66, 67}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern18 : TriggerState {
            internal State퍼즐Pattern18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true, arg3: 1200, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern19 : TriggerState {
            internal State퍼즐Pattern19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern20 : TriggerState {
            internal State퍼즐Pattern20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 21, 31, 32, 33, 34, 35, 36, 37, 38, 39, 29, 19, 18, 17, 16, 15, 14, 13, 12, 22}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 90, 80, 70, 69, 68, 67, 66, 65, 64, 63, 62, 72, 82, 83, 84, 85, 86, 87, 88, 89, 79}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern21 : TriggerState {
            internal State퍼즐Pattern21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 30, 20, 10, 9, 19, 29, 39, 38, 28, 18, 8, 7, 17, 27, 37, 36, 26, 16, 6, 5, 15, 25, 35, 34, 24, 14, 4, 3, 13, 23, 33, 32, 22, 12, 2}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 71, 81, 91, 92, 82, 72, 62, 63, 73, 83, 93, 94, 84, 74, 64, 65, 75, 85, 95, 96, 86, 76, 66, 67, 77, 87, 97, 98, 88, 78, 68, 69, 79, 89, 99}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern22 : TriggerState {
            internal State퍼즐Pattern22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 28, 27, 26, 25, 24, 23, 22, 21, 31}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 90, 89, 88, 87, 86, 85, 84, 83, 82, 72, 73, 74, 75, 76, 77, 78, 79, 80, 70}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern23 : TriggerState {
            internal State퍼즐Pattern23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern24 : TriggerState {
            internal State퍼즐Pattern24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: true, arg3: 1200, arg4: 100);
                context.SetMesh(arg1: new[] {60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true, arg3: 1200, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern25 : TriggerState {
            internal State퍼즐Pattern25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetTimer(id: "1", arg2: 10);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern26 : TriggerState {
            internal State퍼즐Pattern26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 30, 50, 70, 90}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {19, 39, 59, 79, 99}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 28, 48, 68, 88}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {17, 37, 57, 77, 97}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 26, 46, 66, 86}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 21, 41, 61, 81}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {12, 32, 52, 72, 92}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 23, 43, 63, 83}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {14, 34, 54, 74, 94}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 25, 45, 65, 85}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern27 : TriggerState {
            internal State퍼즐Pattern27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 30, 50, 70, 90}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {19, 39, 59, 79, 99}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 28, 48, 68, 88}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {17, 37, 57, 77, 97}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 26, 46, 66, 86}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {15, 35, 55, 75, 95}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 24, 44, 64, 84}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {13, 33, 53, 73, 93}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 22, 42, 62, 82}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 31, 51, 71, 91}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern28 : TriggerState {
            internal State퍼즐Pattern28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 12, 23, 34, 45, 56, 67, 78, 89, 100}, arg2: false, arg3: 4500, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 5000, arg4: 0);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: false, arg3: 5500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 6000, arg4: 0);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: false, arg3: 6500, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 7000, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 7500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 8000, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 8500, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 9000, arg4: 0);
                context.SetMesh(arg1: new[] {10}, arg2: true, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: true, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: true, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: true, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: true, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: true, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: true, arg3: 4500, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: true, arg3: 5000, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: true, arg3: 5500, arg4: 0);
                context.SetMesh(arg1: new[] {1, 12, 23, 34, 45, 56, 67, 78, 89, 100}, arg2: true, arg3: 6000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: true, arg3: 6500, arg4: 0);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: true, arg3: 7000, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: true, arg3: 7500, arg4: 0);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: true, arg3: 8000, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: true, arg3: 8500, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: true, arg3: 9000, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: true, arg3: 9500, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: true, arg3: 10000, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: true, arg3: 10500, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern29 : TriggerState {
            internal State퍼즐Pattern29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern30 : TriggerState {
            internal State퍼즐Pattern30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {18, 17, 16, 15, 14, 13, 12, 11}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89, 99}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23, 22, 21}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78, 88, 98}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {36, 35, 34, 33, 32, 31}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {47, 57, 67, 77, 87, 97}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {46}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {45, 44, 43, 42, 41}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {56, 66, 76, 86, 96}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {54, 53, 52, 51}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {65, 75, 85, 95}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 3900, arg4: 0);
                context.SetMesh(arg1: new[] {63, 62, 61}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {74, 84, 94}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 4200, arg4: 0);
                context.SetMesh(arg1: new[] {72, 71}, arg2: false, arg3: 4300, arg4: 100);
                context.SetMesh(arg1: new[] {83, 93}, arg2: false, arg3: 4300, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern31 : TriggerState {
            internal State퍼즐Pattern31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {18, 17, 16, 15, 14, 13, 12}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {82}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {72, 62, 52, 42, 32, 22}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {83, 84, 85, 86, 87, 88}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {63, 53, 43, 33}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {74, 75, 76, 77}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 3900, arg4: 0);
                context.SetMesh(arg1: new[] {36, 35, 34}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {47, 57, 67}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 4200, arg4: 0);
                context.SetMesh(arg1: new[] {54, 44}, arg2: false, arg3: 4300, arg4: 100);
                context.SetMesh(arg1: new[] {65, 66}, arg2: false, arg3: 4300, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern32 : TriggerState {
            internal State퍼즐Pattern32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23, 22}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78, 88}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {63, 53, 43, 33, 13}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {74, 75, 76, 77, 79}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {46}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {45, 44, 42}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {56, 66, 86}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {35, 15}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {57, 59}, arg2: false, arg3: 3600, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern33 : TriggerState {
            internal State퍼즐Pattern33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 29, 39, 49, 59, 69, 79, 89, 99}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 18, 38, 48, 58, 68, 78, 88, 98}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 17, 27, 47, 57, 67, 77, 87, 97}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 16, 26, 36, 56, 66, 76, 86, 96}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 15, 25, 35, 45, 65, 75, 85, 95}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 14, 24, 34, 44, 54, 74, 84, 94}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 13, 23, 33, 43, 53, 63, 83, 93}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 12, 22, 32, 42, 52, 62, 72, 92}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 11, 21, 31, 41, 51, 61, 71, 81}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern34 : TriggerState {
            internal State퍼즐Pattern34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {46, 56, 55, 45, 35, 36, 37, 47, 57, 67, 66, 65, 64, 54, 44, 34, 24, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 23, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22, 12}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern35 : TriggerState {
            internal State퍼즐Pattern35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {46, 56, 55, 45, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 23, 24, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern36 : TriggerState {
            internal State퍼즐Pattern36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {46, 56, 55, 45, 35, 25, 15, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22, 23, 24, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 34, 35, 36, 37, 47, 57, 67, 66, 65, 64, 54, 44}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern37 : TriggerState {
            internal State퍼즐Pattern37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {46, 56, 55, 45, 64, 54, 44, 34, 35, 36, 37, 47, 57, 67, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 23, 82, 72, 62, 52, 42, 32, 22, 12, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49, 59, 69, 79, 89, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 1}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern38 : TriggerState {
            internal State퍼즐Pattern38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {45, 34, 23, 12, 1}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {46, 37, 28, 19, 10}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {56, 67, 78, 89, 100}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {55, 64, 73, 82, 91}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {44, 33, 22, 11}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {35, 24, 13, 2}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {36, 27, 18, 9}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {47, 38, 29, 20}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {57, 68, 79, 90}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {66, 77, 88, 99}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {65, 74, 83, 92}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {54, 63, 72, 81}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {43, 32, 21}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {25, 14, 3}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {26, 17, 8}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {48, 39, 30}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {58, 69, 80}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {76, 87, 98}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {75, 84, 93}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {53, 62, 71}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {42, 31}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {15, 4}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {16, 7}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {49, 40}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {59, 70}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {86, 97}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {85, 94}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {52, 61}, arg2: false, arg3: 3500, arg4: 200);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern39 : TriggerState {
            internal State퍼즐Pattern39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {45}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {35, 25, 15, 5}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 41}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {46}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {36, 26, 16, 6}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {47, 48, 49, 50}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {56}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {57, 58, 59, 60}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {66, 76, 86, 96}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {65, 75, 85, 95}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {54, 53, 52, 51}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {74, 84, 94}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {63, 62, 61}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {34}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {33, 32, 31}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {24, 14, 4}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {38, 39, 40}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {27, 17, 7}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {67}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {77, 87, 97}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {68, 69, 70}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {83, 93}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {72, 71}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {23}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {22, 21}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {13, 3}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {18, 8}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {29, 30}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {78}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {79, 80}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {88, 98}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {82}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {81}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {92}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {12}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {11}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {2}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {20}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {9}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {89}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {99}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {90}, arg2: false, arg3: 2500, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern40 : TriggerState {
            internal State퍼즐Pattern40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 19, 28, 37, 46, 55, 64, 73, 82, 91}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {9, 18, 27, 36, 45, 54, 63, 72, 81, 20, 29, 38, 47, 56, 65, 74, 83, 92}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {8, 17, 26, 35, 44, 53, 62, 71, 30, 39, 48, 57, 66, 75, 84, 93}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {7, 16, 25, 34, 43, 52, 61, 40, 49, 58, 67, 76, 85, 94}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {6, 15, 24, 33, 42, 51, 50, 59, 68, 77, 86, 95}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {5, 14, 23, 32, 41, 60, 69, 78, 87, 96}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 13, 22, 31, 70, 79, 88, 97}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 12, 21, 80, 89, 98}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 11, 90, 99}, arg2: false, arg3: 4000, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern41 : TriggerState {
            internal State퍼즐Pattern41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 19, 28, 37, 46, 55, 64, 73, 82, 91}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 18, 27, 36, 45, 54, 63, 72, 62, 52, 42, 32, 22, 12, 13, 14, 15, 16, 17, 26, 35, 44, 53, 43, 33, 23}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 29, 38, 47, 56, 65, 74, 83, 84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 48, 57, 66, 75, 76, 77, 78}, arg2: false, arg3: 1000, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern42 : TriggerState {
            internal State퍼즐Pattern42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 19, 28, 37, 46, 55, 64, 73, 82, 91}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 72, 62, 52, 42, 32, 22, 12, 13, 14, 15, 16, 17, 18, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 63, 53, 43, 33, 23, 24, 25, 26, 27, 38, 48, 58, 68, 78, 77, 76, 75, 74, 54, 44, 34, 35, 36, 47, 57, 67, 66, 65}, arg2: false, arg3: 1000, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern43 : TriggerState {
            internal State퍼즐Pattern43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 100, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 200, arg4: 100);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 600, arg4: 100);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 900, arg4: 100);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1200, arg4: 100);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 2000, arg4: 100);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 4200, arg4: 100);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 4900, arg4: 100);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: false, arg3: 5600, arg4: 100);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: false, arg3: 6400, arg4: 100);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 7200, arg4: 100);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 8100, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern44 : TriggerState {
            internal State퍼즐Pattern44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 1900, arg4: 0);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 2000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99}, arg2: false, arg3: 2800, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 3600, arg4: 0);
                context.SetMesh(arg1: new[] {18, 17, 16, 15, 14, 13, 12}, arg2: false, arg3: 3700, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89}, arg2: false, arg3: 4400, arg4: 100);
                context.SetMesh(arg1: new[] {82}, arg2: false, arg3: 5100, arg4: 0);
                context.SetMesh(arg1: new[] {72, 62, 52, 42, 32, 22}, arg2: false, arg3: 5200, arg4: 100);
                context.SetMesh(arg1: new[] {83, 84, 85, 86, 87, 88}, arg2: false, arg3: 5800, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 6400, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23}, arg2: false, arg3: 6500, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78}, arg2: false, arg3: 7000, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 7500, arg4: 0);
                context.SetMesh(arg1: new[] {63, 53, 43, 33}, arg2: false, arg3: 7600, arg4: 100);
                context.SetMesh(arg1: new[] {74, 75, 76, 77}, arg2: false, arg3: 8000, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 8400, arg4: 0);
                context.SetMesh(arg1: new[] {36, 35, 34}, arg2: false, arg3: 8500, arg4: 100);
                context.SetMesh(arg1: new[] {47, 57, 67}, arg2: false, arg3: 8800, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 9100, arg4: 0);
                context.SetMesh(arg1: new[] {54, 44}, arg2: false, arg3: 9200, arg4: 100);
                context.SetMesh(arg1: new[] {65, 66}, arg2: false, arg3: 9400, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern45 : TriggerState {
            internal State퍼즐Pattern45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27}, arg2: false, arg3: 800, arg4: 100);
                context.SetMesh(arg1: new[] {64, 63, 73, 74}, arg2: false, arg3: 1200, arg4: 100);
                context.SetMesh(arg1: new[] {55, 45, 46, 56}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, arg2: false, arg3: 2000, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {12, 13, 14, 15, 16, 17, 18, 19}, arg2: false, arg3: 5600, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22}, arg2: false, arg3: 6400, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern46 : TriggerState {
            internal State퍼즐Pattern46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {33, 23, 24, 34}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 45}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {67, 77, 78, 68, 58, 57, 56, 66, 76, 86, 87, 88, 89, 79, 69, 59}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27, 26, 36, 46, 47, 48, 49, 39, 29, 19, 18, 17, 16}, arg2: false, arg3: 3200, arg4: 100);
                context.SetMesh(arg1: new[] {64, 63, 73, 74, 75, 65, 55, 54, 53, 52, 62, 72, 82, 83, 84, 85}, arg2: false, arg3: 4800, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern47 : TriggerState {
            internal State퍼즐Pattern47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {33, 23, 24, 34}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 45}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {55, 54, 53, 52, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 16, 26, 36, 46, 56}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7}, arg2: false, arg3: 4900, arg4: 100);
                context.SetMesh(arg1: new[] {17, 27, 37, 47, 57, 67, 77, 87, 88, 89, 79, 69, 59, 49, 39, 29, 19, 18, 28, 38, 48, 58, 68, 78, 88}, arg2: false, arg3: 6100, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern48 : TriggerState {
            internal State퍼즐Pattern48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {33, 23, 24, 34}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 45}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {55, 54, 53, 52, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 16, 26, 36, 46, 56}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {90, 80, 70, 60, 50, 40, 30, 20, 10}, arg2: false, arg3: 4900, arg4: 100);
                context.SetMesh(arg1: new[] {9, 19, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 73, 74, 75, 76, 77, 78, 68, 67, 66, 65, 64, 63, 62}, arg2: false, arg3: 5800, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern49 : TriggerState {
            internal State퍼즐Pattern49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {45, 44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 56, 57, 58, 59, 69, 79, 89, 88, 87, 86, 76, 66}, arg2: false, arg3: 800, arg4: 100);
                context.SetMesh(arg1: new[] {55, 54, 53, 52, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 16, 26, 36, 46, 47, 48, 49, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 85, 75, 65}, arg2: false, arg3: 3200, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 7000, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 7000, arg4: 100);
                context.SetMesh(arg1: new[] {63, 62, 61}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {74, 84, 94}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {27, 17, 7}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {38, 39, 40}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 7700, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 7700, arg4: 100);
                context.SetMesh(arg1: new[] {18, 8}, arg2: false, arg3: 8200, arg4: 100);
                context.SetMesh(arg1: new[] {29, 30}, arg2: false, arg3: 8200, arg4: 100);
                context.SetMesh(arg1: new[] {72, 71}, arg2: false, arg3: 8200, arg4: 100);
                context.SetMesh(arg1: new[] {83, 93}, arg2: false, arg3: 8200, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern50 : TriggerState {
            internal State퍼즐Pattern50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27, 64, 63, 73, 74}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {82, 81, 91, 92, 19, 20, 10, 9}, arg2: false, arg3: 2100, arg4: 100);
                context.SetMesh(arg1: new[] {12, 11, 1, 2, 89, 90, 99, 100}, arg2: false, arg3: 3200, arg4: 100);
                context.SetMesh(arg1: new[] {15, 5, 6, 16, 86, 96, 85, 95}, arg2: false, arg3: 4300, arg4: 100);
                context.SetMesh(arg1: new[] {42, 41, 51, 52, 59, 60, 50, 49}, arg2: false, arg3: 5400, arg4: 100);
                context.SetMesh(arg1: new[] {55, 45, 46, 56}, arg2: false, arg3: 6500, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern51 : TriggerState {
            internal State퍼즐Pattern51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27, 64, 63, 73, 74}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {82, 83, 93, 92, 91, 81, 71, 72, 19, 18, 8, 9, 10, 20, 30, 29}, arg2: false, arg3: 2100, arg4: 100);
                context.SetMesh(arg1: new[] {12, 22, 21, 11, 1, 2, 3, 13, 89, 79, 80, 90, 100, 99, 98, 88}, arg2: false, arg3: 3700, arg4: 100);
                context.SetMesh(arg1: new[] {15, 5, 6, 16, 86, 96, 85, 95}, arg2: false, arg3: 5300, arg4: 100);
                context.SetMesh(arg1: new[] {42, 41, 51, 52, 59, 60, 50, 49}, arg2: false, arg3: 6400, arg4: 100);
                context.SetMesh(arg1: new[] {55, 45, 46, 56}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {66, 65, 54, 44, 35, 36, 47, 57}, arg2: false, arg3: 8100, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern52 : TriggerState {
            internal State퍼즐Pattern52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6}, arg2: false, arg3: 500, arg4: 100);
                context.SetMesh(arg1: new[] {18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37}, arg2: false, arg3: 1400, arg4: 100);
                context.SetMesh(arg1: new[] {68, 58, 59, 69, 79, 78, 77, 67, 57, 47, 48, 49, 50, 60, 70, 80, 90, 89, 88, 87, 86, 76, 66, 56, 46}, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {73, 74, 84, 83, 82, 72, 62, 63, 64, 65, 75, 85, 95, 94, 93, 92}, arg2: false, arg3: 5500, arg4: 100);
                context.SetMesh(arg1: new[] {42, 43, 53, 52, 51, 41, 31, 32, 33}, arg2: false, arg3: 7100, arg4: 100);
                context.SetMesh(arg1: new[] {44, 34, 35, 45}, arg2: false, arg3: 8000, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 8400, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern53 : TriggerState {
            internal State퍼즐Pattern53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6}, arg2: false, arg3: 500, arg4: 100);
                context.SetMesh(arg1: new[] {18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37}, arg2: false, arg3: 1400, arg4: 100);
                context.SetMesh(arg1: new[] {68, 58, 59, 69, 79, 78, 77, 67, 57, 47, 48, 49, 50, 60, 70, 80, 90, 89, 88, 87, 86, 76, 66, 56, 46}, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {96}, arg2: false, arg3: 5500, arg4: 100);
                context.SetMesh(arg1: new[] {95, 94, 84, 85}, arg2: false, arg3: 5600, arg4: 100);
                context.SetMesh(arg1: new[] {82, 83, 93, 92, 91, 81, 71, 72, 73}, arg2: false, arg3: 6000, arg4: 100);
                context.SetMesh(arg1: new[] {52, 42, 43, 53, 63, 62, 61, 51, 41, 31, 32, 33, 34, 44, 54, 64}, arg2: false, arg3: 6900, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern54 : TriggerState {
            internal State퍼즐Pattern54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 100}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3, 88, 89, 99, 98}, arg2: false, arg3: 200, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6, 86, 85, 75, 76, 77, 87, 97, 96, 95}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37, 83, 82, 72, 73, 74, 84, 94, 93, 92, 91, 81, 71, 61, 62, 63, 64}, arg2: false, arg3: 2800, arg4: 100);
                context.SetMesh(arg1: new[] {50, 51}, arg2: false, arg3: 6000, arg4: 100);
                context.SetMesh(arg1: new[] {60, 70, 69, 59, 41, 31, 32, 42}, arg2: false, arg3: 6200, arg4: 100);
                context.SetMesh(arg1: new[] {57, 58, 68, 67, 66, 56, 46, 47, 48, 44, 43, 33, 34, 35, 45, 55, 54, 53}, arg2: false, arg3: 7000, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern55 : TriggerState {
            internal State퍼즐Pattern55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 100}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3, 88, 89, 99, 98}, arg2: false, arg3: 200, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6, 86, 85, 75, 76, 77, 87, 97, 96, 95}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37, 83, 82, 72, 73, 74, 84, 94, 93, 92, 91, 81, 71, 61, 62, 63, 64}, arg2: false, arg3: 2800, arg4: 100);
                context.SetMesh(arg1: new[] {59, 60, 70, 69, 68, 58, 48, 49, 50, 42, 41, 31, 32, 33, 43, 53, 52, 51}, arg2: false, arg3: 6000, arg4: 100);
                context.SetMesh(arg1: new[] {56, 57, 67, 66, 45, 44, 34, 35}, arg2: false, arg3: 7800, arg4: 100);
                context.SetMesh(arg1: new[] {46, 55}, arg2: false, arg3: 8600, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern56 : TriggerState {
            internal State퍼즐Pattern56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 69, 79, 89, 88, 87, 84, 83, 82, 72, 62, 22, 25, 26, 38, 48, 58, 78, 76, 75, 73, 53, 43, 33, 34, 37, 47, 57, 67, 66, 65, 64, 54, 44, 45, 46, 56, 55}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern57 : TriggerState {
            internal State퍼즐Pattern57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 8, 9, 10, 20, 30, 40, 50, 90, 100, 99, 92, 91, 81, 41, 31, 21, 11, 12, 13, 14, 17, 18, 19, 29, 39, 59, 69, 79, 88, 87, 86, 85, 84, 83, 72, 62, 52, 32, 22, 23, 26, 27, 28, 48, 58, 68, 78, 77, 74, 73, 63, 53, 43, 34, 35, 47, 67, 66, 65, 64, 44, 45, 46, 56, 55}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern58 : TriggerState {
            internal State퍼즐Pattern58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 72, 62, 52, 42, 32, 22, 23, 25, 26, 48, 58, 78, 77, 76, 75, 53, 43, 33, 34, 37, 67, 66, 64, 44, 46, 55}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern59 : TriggerState {
            internal State퍼즐Pattern59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 2, 6, 7, 8, 9, 10, 20, 30, 40, 50, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 13, 14, 15, 17, 18, 19, 29, 39, 59, 69, 79, 78, 77, 76, 75, 74, 73, 23, 24, 25, 27, 28, 38, 58, 68, 67, 66, 65, 64, 63, 53, 43, 33, 34, 35, 37, 57, 67, 66, 65, 64, 54, 44, 45, 56, 55}, arg2: false, arg3: 0, arg4: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern60 : TriggerState {
            internal State퍼즐Pattern60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {28, 39, 50}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 49, 60}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 59, 70}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 47, 69, 80}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 46, 57, 90}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 12, 23, 34, 45, 56, 78, 100}, arg2: false, arg3: 4500, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 55, 66, 77, 88, 99}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {21, 43, 65, 87}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {52, 74, 85, 96}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {73, 84, 95}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}