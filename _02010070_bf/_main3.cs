using System;

namespace Maple2.Trigger._02010070_bf {
    public static class _main3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,
                        119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137,
                        138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156,
                        157, 158, 159, 160, 161, 162, 163
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182,
                        183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201,
                        202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318,
                        319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337,
                        338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356,
                        357, 358, 359, 360, 361, 362, 363
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418,
                        419, 420, 421, 422, 423, 424, 425, 426, 427, 428
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448,
                        449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {220, 221, 222, 223}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {3000});
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: false);
                context.SetEffect(arg1: new int[] {9000}, arg2: false);
                context.SetSkill(arg1: new int[] {9001}, arg2: false);
                context.SetSkill(arg1: new int[] {9002}, arg2: false);
                context.SetSkill(arg1: new int[] {9003}, arg2: false);
                context.SetSkill(arg1: new int[] {9004}, arg2: false);
                context.SetEffect(arg1: new int[] {95000}, arg2: false);
                context.SetEffect(arg1: new int[] {95003}, arg2: false);
                context.SetEffect(arg1: new int[] {95010}, arg2: false);
                context.SetEffect(arg1: new int[] {95002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {999994})) {
                    context.State = new State대기시간안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간안내01 : TriggerState {
            internal State대기시간안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기시간안내02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간안내02 : TriggerState {
            internal State대기시간안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20100703, textID: 20100703);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작1 : TriggerState {
            internal State시작1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {3000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작2 : TriggerState {
            internal State시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20100703);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3000})) {
                    context.State = new State시작3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작3 : TriggerState {
            internal State시작3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 88321, arg2: "trigger", arg3: "kakalfillusion");
                context.SetEffect(arg1: new int[] {9000}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20100704, textID: 20100704);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {999995})) {
                    context.State = new State시작35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작35 : TriggerState {
            internal State시작35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02010070, arg2: 11);
                context.SetMesh(arg1: new int[] {220, 221, 222, 223}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작4(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(
                    arg1: new int[] {
                        100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,
                        119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137,
                        138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156,
                        157, 158, 159, 160, 161, 162, 163
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182,
                        183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201,
                        202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State시작4 : TriggerState {
            internal State시작4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9000}, arg2: false);
                context.SetSkill(arg1: new int[] {9001}, arg2: true);
                context.SetEffect(arg1: new int[] {95002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State시작5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작5 : TriggerState {
            internal State시작5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20100704);
                context.SetSkill(arg1: new int[] {9002}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작6 : TriggerState {
            internal State시작6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318,
                        319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337,
                        338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356,
                        357, 358, 359, 360, 361, 362, 363
                    }, arg2: true, arg3: 0, arg4: 50, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418,
                        419, 420, 421, 422, 423, 424, 425, 426, 427, 428
                    }, arg2: true, arg3: 0, arg4: 50, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448,
                        449, 450, 451, 452, 453, 454, 455, 456, 457, 458
                    }, arg2: true, arg3: 0, arg4: 50, arg5: 0f);
                context.SetSkill(arg1: new int[] {9003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작7 : TriggerState {
            internal State시작7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478,
                        479, 480, 481
                    }, arg2: true, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508},
                    arg2: true, arg3: 0, arg4: 200, arg5: 0f);
                context.SetEffect(arg1: new int[] {95003}, arg2: true);
                context.SetSkill(arg1: new int[] {9004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State시작8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작8 : TriggerState {
            internal State시작8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,
                        119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137,
                        138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156,
                        157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175,
                        176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194,
                        195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02010070_BF__MAIN__5$", arg3: new int[] {6000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {220, 221, 222, 223}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StatePCGetOut01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut01 : TriggerState {
            internal StatePCGetOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StatePCGetOut02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut02 : TriggerState {
            internal StatePCGetOut02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StatePCGetOut03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut03 : TriggerState {
            internal StatePCGetOut03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StatePCGetOut04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut04 : TriggerState {
            internal StatePCGetOut04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}