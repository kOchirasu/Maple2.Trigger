namespace Maple2.Trigger._61000005_me {
    public static class _mainprocess {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {196})) {
                    return new State퍼즐Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Waiting : TriggerState {
            internal State퍼즐Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "퍼즐패턴1,퍼즐패턴2,퍼즐패턴3", arg3: true);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494}, arg2: true);
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 551, 552}, arg2: false);
                context.SetPortal(arg1: 101, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 102, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 103, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 104, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 115, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 116, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 117, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 118, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 500, arg2: false, arg3: true, arg4: false);
                context.DestroyMonster(arg1: new[] {202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 90000)) {
                    return new StateBeginWaitMassiveEvent1(context);
                }

                if (context.GetUserCount(boxId: 196) == 20) {
                    return new StateBeginWaitMassiveEvent1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWaitMassiveEvent1 : TriggerState {
            internal StateBeginWaitMassiveEvent1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__0$", arg3: 4500);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBeginWaitMassiveEvent2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWaitMassiveEvent2 : TriggerState {
            internal StateBeginWaitMassiveEvent2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__1$", arg3: 4500);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBeginWaitMassiveEvent3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWaitMassiveEvent3 : TriggerState {
            internal StateBeginWaitMassiveEvent3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__2$", arg3: 4500);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBeginWaitMassiveEvent4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWaitMassiveEvent4 : TriggerState {
            internal StateBeginWaitMassiveEvent4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__3$", arg3: 4500);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBeginWaitMassiveEvent5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWaitMassiveEvent5 : TriggerState {
            internal StateBeginWaitMassiveEvent5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__4$", arg3: 4500);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1, arg2: "퍼즐패턴1,퍼즐패턴2,퍼즐패턴3", arg3: true);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208}, arg2: false);
                context.SetPortal(arg1: 101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 102, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 103, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 104, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 115, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 116, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 117, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 118, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__5$", arg3: 4500);
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMassiveEvent1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMassiveEvent1 : TriggerState {
            internal StateMassiveEvent1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.ShowCountUI(text: "$61000005_ME__MAINPROCESS__6$", stage: 1, count: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계1 : TriggerState {
            internal State퍼즐단계1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State퍼즐단계1정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계1정리 : TriggerState {
            internal State퍼즐단계1정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계1종료(context);
                }

                if (!context.UserDetected(arg1: new[] {197, 198, 199})) {
                    return new State모두실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계1종료 : TriggerState {
            internal State퍼즐단계1종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {197, 198, 199})) {
                    return new State퍼즐단계2Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계2Wait : TriggerState {
            internal State퍼즐단계2Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.ShowCountUI(text: "$61000005_ME__MAINPROCESS__7$", stage: 2, count: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계2 : TriggerState {
            internal State퍼즐단계2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State퍼즐단계2정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "99");
            }
        }

        private class State퍼즐단계2정리 : TriggerState {
            internal State퍼즐단계2정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계2종료(context);
                }

                if (!context.UserDetected(arg1: new[] {197, 198, 199})) {
                    return new State모두실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계2종료 : TriggerState {
            internal State퍼즐단계2종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {197, 198, 199})) {
                    return new State퍼즐단계3Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계3Wait : TriggerState {
            internal State퍼즐단계3Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.ShowCountUI(text: "$61000005_ME__MAINPROCESS__8$", stage: 3, count: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계3 : TriggerState {
            internal State퍼즐단계3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    return new State퍼즐단계3정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계3정리 : TriggerState {
            internal State퍼즐단계3정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계3종료(context);
                }

                if (!context.UserDetected(arg1: new[] {197, 198, 199})) {
                    return new State모두실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계3종료 : TriggerState {
            internal State퍼즐단계3종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {197, 198, 199})) {
                    context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176}, arg2: true);
                    return new State보상단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상단계 : TriggerState {
            internal State보상단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__9$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State돈벼락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돈벼락 : TriggerState {
            internal State돈벼락(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__10$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {197, 198, 199}, arg2: 70000020, arg3: 1);
                context.CreateItem(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073, 1074, 1075});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐종료처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모두실패 : TriggerState {
            internal State모두실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 5, arg2: "$61000005_ME__MAINPROCESS__11$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐종료처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐종료처리 : TriggerState {
            internal State퍼즐종료처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__MAINPROCESS__12$", arg3: 5000);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176}, arg2: true);
                context.SetMesh(arg1: new[] {211, 212, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494}, arg2: false);
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 551, 552}, arg2: true);
                context.SetPortal(arg1: 101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 102, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 103, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 104, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 115, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 116, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 117, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 118, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 500, arg2: false, arg3: true, arg4: false);
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State강제종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제종료 : TriggerState {
            internal State강제종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.MoveUser(arg1: 63000001, arg2: 5, arg3: 0);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern1 : TriggerState {
            internal State퍼즐Pattern1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {101, 102, 103, 104}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {128, 138, 148, 158}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {176, 175, 174, 173}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {149, 139, 129, 119}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {110, 109, 108, 107, 106, 105}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {166, 157, 147, 137, 127, 118}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {167, 168, 169, 170, 171, 172}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {111, 120, 130, 140, 150, 159}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {112, 113, 114, 115, 116}, arg2: false, arg3: 4500, arg4: 300);
                context.SetMesh(arg1: new[] {117, 126, 136, 146, 156}, arg2: false, arg3: 4500, arg4: 300);
                context.SetMesh(arg1: new[] {165, 164, 163, 162, 161}, arg2: false, arg3: 4500, arg4: 300);
                context.SetMesh(arg1: new[] {160, 151, 141, 131, 121}, arg2: false, arg3: 4500, arg4: 300);
                context.SetMesh(arg1: new[] {125, 124, 123}, arg2: false, arg3: 6500, arg4: 300);
                context.SetMesh(arg1: new[] {122, 132, 142}, arg2: false, arg3: 6500, arg4: 300);
                context.SetMesh(arg1: new[] {152, 153, 154}, arg2: false, arg3: 6500, arg4: 300);
                context.SetMesh(arg1: new[] {155, 145, 135}, arg2: false, arg3: 6500, arg4: 300);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern2 : TriggerState {
            internal State퍼즐Pattern2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {133, 134, 144, 143}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {142, 132, 122, 123, 124, 125}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {135, 145, 155, 154, 153, 152}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {113, 114, 115, 116, 117, 126, 136, 146, 156, 165}, arg2: false, arg3: 5500, arg4: 300);
                context.SetMesh(arg1: new[] {164, 163, 162, 161, 160, 151, 141, 131, 121, 112}, arg2: false, arg3: 5500, arg4: 300);
                context.SetMesh(arg1: new[] {105, 106, 107, 108, 109, 110}, arg2: false, arg3: 9500, arg4: 300);
                context.SetMesh(arg1: new[] {118, 127, 137, 147, 157, 166}, arg2: false, arg3: 9500, arg4: 300);
                context.SetMesh(arg1: new[] {172, 171, 170, 169, 168, 167}, arg2: false, arg3: 9500, arg4: 300);
                context.SetMesh(arg1: new[] {159, 150, 140, 130, 120, 111}, arg2: false, arg3: 9500, arg4: 300);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Pattern3 : TriggerState {
            internal State퍼즐Pattern3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {101, 102, 103, 104}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {128, 138, 148, 158}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {176, 175, 174, 173}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {149, 139, 129, 119}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {133, 134, 144, 143}, arg2: false, arg3: 0, arg4: 300);
                context.SetMesh(arg1: new[] {105, 106, 107, 108, 109, 110}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {118, 127, 137, 147, 157, 166}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {172, 171, 170, 169, 168, 167}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {159, 150, 140, 130, 120, 111}, arg2: false, arg3: 2500, arg4: 300);
                context.SetMesh(arg1: new[] {122, 123, 124}, arg2: false, arg3: 2500, arg4: 600);
                context.SetMesh(arg1: new[] {125, 135, 145}, arg2: false, arg3: 2500, arg4: 600);
                context.SetMesh(arg1: new[] {155, 154, 153}, arg2: false, arg3: 2500, arg4: 600);
                context.SetMesh(arg1: new[] {152, 142, 132}, arg2: false, arg3: 2500, arg4: 600);
                context.SetMesh(arg1: new[] {112, 117, 165, 160}, arg2: false, arg3: 6500, arg4: 300);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}