using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000252_bf {
    public static class _start {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {151, 152, 153, 154, 155, 156}, arg2: true);
                context.SetEffect(arg1: new[] {601, 602, 603, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new State로딩딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로딩딜레이 : TriggerState {
            internal State로딩딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002521);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출해제 : TriggerState {
            internal State연출해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라소환 : TriggerState {
            internal State벨라소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8801, 8802}, arg2: false);
                context.CreateMonster(arg1: new[] {1001});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State벨라대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사 : TriggerState {
            internal State벨라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "벨라스킬딜레이", arg2: "nextState");
                context.SetSkip(arg1: "벨라스킬딜레이");
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__4$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사2 : TriggerState {
            internal State벨라대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 8);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__5$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사3 : TriggerState {
            internal State벨라대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetSceneSkip();
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__6$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6243)) {
                    context.State = new State벨라스킬딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라스킬딜레이 : TriggerState {
            internal State벨라스킬딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1");
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State예고이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예고이펙트 : TriggerState {
            internal State예고이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8804}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 999, arg2: "trigger", arg3: "Bellafirst");
                context.SetEffect(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State스킬시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬시작대기 : TriggerState {
            internal State스킬시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002522, textId: 20002522);
                context.SetMesh(arg1: new[] {151, 152, 153, 154, 155, 156}, arg2: false);
                context.CreateMonster(arg1: new[] {1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.DestroyMonster(arg1: new[] {1001});
                    context.State = new State스킬시작대기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬시작대기2 : TriggerState {
            internal State스킬시작대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08 : TriggerState {
            internal State스킬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬07대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07대기 : TriggerState {
            internal State스킬07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07 : TriggerState {
            internal State스킬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {564, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06대기 : TriggerState {
            internal State스킬06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {564, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06 : TriggerState {
            internal State스킬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {565, 564, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬05대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05대기 : TriggerState {
            internal State스킬05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002522);
                context.SetSkill(arg1: new[] {565, 564, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05 : TriggerState {
            internal State스킬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {566, 567, 568, 565, 564, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04대기 : TriggerState {
            internal State스킬04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {566, 567, 568, 565, 564, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04 : TriggerState {
            internal State스킬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {566, 567, 568}, arg2: false);
                context.SetSkill(arg1: new[] {565, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03대기 : TriggerState {
            internal State스킬03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {566, 567, 568, 565, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03 : TriggerState {
            internal State스킬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {566, 567, 568, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02대기 : TriggerState {
            internal State스킬02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {566, 567, 568, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02 : TriggerState {
            internal State스킬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬01대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01대기 : TriggerState {
            internal State스킬01대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01 : TriggerState {
            internal State스킬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬00대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬00대기 : TriggerState {
            internal State스킬00대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬00 : TriggerState {
            internal State스킬00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬0_5대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬0_5대기 : TriggerState {
            internal State스킬0_5대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬0_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬0_5 : TriggerState {
            internal State스킬0_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬01대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08대기 : TriggerState {
            internal State스킬08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000409}, arg2: 0)) {
                    context.State = new State굳음(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State굳음 : TriggerState {
            internal State굳음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09대기 : TriggerState {
            internal State스킬09대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09 : TriggerState {
            internal State스킬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬10대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10대기 : TriggerState {
            internal State스킬10대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10 : TriggerState {
            internal State스킬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬11대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11대기 : TriggerState {
            internal State스킬11대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 0);
                context.SetSkill(arg1: new[] {359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12 : TriggerState {
            internal State스킬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬13대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13대기 : TriggerState {
            internal State스킬13대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13 : TriggerState {
            internal State스킬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬14대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14대기 : TriggerState {
            internal State스킬14대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14 : TriggerState {
            internal State스킬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬15대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15대기 : TriggerState {
            internal State스킬15대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15 : TriggerState {
            internal State스킬15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬16대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16대기 : TriggerState {
            internal State스킬16대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16 : TriggerState {
            internal State스킬16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬17대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17대기 : TriggerState {
            internal State스킬17대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17 : TriggerState {
            internal State스킬17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬18대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18대기 : TriggerState {
            internal State스킬18대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18 : TriggerState {
            internal State스킬18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬19대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19대기 : TriggerState {
            internal State스킬19대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19 : TriggerState {
            internal State스킬19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬20대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20대기 : TriggerState {
            internal State스킬20대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20 : TriggerState {
            internal State스킬20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬21대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21대기 : TriggerState {
            internal State스킬21대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21 : TriggerState {
            internal State스킬21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬22대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22대기 : TriggerState {
            internal State스킬22대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22 : TriggerState {
            internal State스킬22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬23대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23대기 : TriggerState {
            internal State스킬23대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23 : TriggerState {
            internal State스킬23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬24대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24대기 : TriggerState {
            internal State스킬24대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24 : TriggerState {
            internal State스킬24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬25대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25대기 : TriggerState {
            internal State스킬25대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25 : TriggerState {
            internal State스킬25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬26대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26대기 : TriggerState {
            internal State스킬26대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26 : TriggerState {
            internal State스킬26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬27대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27대기 : TriggerState {
            internal State스킬27대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27 : TriggerState {
            internal State스킬27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬28대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28대기 : TriggerState {
            internal State스킬28대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28 : TriggerState {
            internal State스킬28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬29대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29대기 : TriggerState {
            internal State스킬29대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29 : TriggerState {
            internal State스킬29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬30대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30대기 : TriggerState {
            internal State스킬30대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30 : TriggerState {
            internal State스킬30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬31대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31대기 : TriggerState {
            internal State스킬31대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31 : TriggerState {
            internal State스킬31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬32대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32대기 : TriggerState {
            internal State스킬32대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32 : TriggerState {
            internal State스킬32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬33대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33대기 : TriggerState {
            internal State스킬33대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 0);
                context.SetSkill(arg1: new[] {491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33 : TriggerState {
            internal State스킬33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}