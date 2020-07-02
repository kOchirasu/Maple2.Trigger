using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000252_bf {
    public static class _start {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {151, 152, 153, 154, 155, 156}, arg2: true);
                context.SetEffect(arg1: new[] {601, 602, 603, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로딩Delay : TriggerState {
            internal State로딩Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라소환(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라소환(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State벨라대사(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라대사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라대사2 : TriggerState {
            internal State벨라대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 8);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000252_BF__START__5$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라대사3(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6243)) {
                    return new State벨라스킬Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라스킬Delay : TriggerState {
            internal State벨라스킬Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1");
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State예고이펙트(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateSkill시작대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill시작대기 : TriggerState {
            internal StateSkill시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002522, textId: 20002522);
                context.SetMesh(arg1: new[] {151, 152, 153, 154, 155, 156}, arg2: false);
                context.CreateMonster(arg1: new[] {1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.DestroyMonster(arg1: new[] {1001});
                    return new StateSkill시작대기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill시작대기2 : TriggerState {
            internal StateSkill시작대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateSkill08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill08 : TriggerState {
            internal StateSkill08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill07대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill07대기 : TriggerState {
            internal StateSkill07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill07(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill07 : TriggerState {
            internal StateSkill07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {564, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill06대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill06대기 : TriggerState {
            internal StateSkill06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {564, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill06(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill06 : TriggerState {
            internal StateSkill06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {565, 564, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill05대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill05대기 : TriggerState {
            internal StateSkill05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002522);
                context.SetSkill(arg1: new[] {565, 564, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill05(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill05 : TriggerState {
            internal StateSkill05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {566, 567, 568, 565, 564, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill04대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill04대기 : TriggerState {
            internal StateSkill04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {566, 567, 568, 565, 564, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill04(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill04 : TriggerState {
            internal StateSkill04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {566, 567, 568}, arg2: false);
                context.SetSkill(arg1: new[] {565, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill03대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill03대기 : TriggerState {
            internal StateSkill03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {566, 567, 568, 565, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill03(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill03 : TriggerState {
            internal StateSkill03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {566, 567, 568, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill02대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill02대기 : TriggerState {
            internal StateSkill02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {566, 567, 568, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill02(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill02 : TriggerState {
            internal StateSkill02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill01대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill01대기 : TriggerState {
            internal StateSkill01대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill01(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill01 : TriggerState {
            internal StateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill00대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill00대기 : TriggerState {
            internal StateSkill00대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill00(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill00 : TriggerState {
            internal StateSkill00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill0_5대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill0_5대기 : TriggerState {
            internal StateSkill0_5대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill0_5(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill0_5 : TriggerState {
            internal StateSkill0_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {558, 559, 560, 561, 562, 563, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill01대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill08대기 : TriggerState {
            internal StateSkill08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000409}, arg2: 0)) {
                    return new State굳음(context);
                }

                return new StateSkill08(context);
            }

            public override void OnExit() { }
        }

        private class State굳음 : TriggerState {
            internal State굳음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new StateSkill08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill09대기 : TriggerState {
            internal StateSkill09대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill09(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill09 : TriggerState {
            internal StateSkill09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill10대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill10대기 : TriggerState {
            internal StateSkill10대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill10(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill10 : TriggerState {
            internal StateSkill10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill11대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill11대기 : TriggerState {
            internal StateSkill11대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 0);
                context.SetSkill(arg1: new[] {359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill12(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill12 : TriggerState {
            internal StateSkill12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill13대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill13대기 : TriggerState {
            internal StateSkill13대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill13(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill13 : TriggerState {
            internal StateSkill13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill14대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill14대기 : TriggerState {
            internal StateSkill14대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill14(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill14 : TriggerState {
            internal StateSkill14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill15대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill15대기 : TriggerState {
            internal StateSkill15대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill15(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill15 : TriggerState {
            internal StateSkill15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill16대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill16대기 : TriggerState {
            internal StateSkill16대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill16(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill16 : TriggerState {
            internal StateSkill16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill17대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill17대기 : TriggerState {
            internal StateSkill17대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill17(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill17 : TriggerState {
            internal StateSkill17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill18대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill18대기 : TriggerState {
            internal StateSkill18대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill18(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill18 : TriggerState {
            internal StateSkill18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill19대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill19대기 : TriggerState {
            internal StateSkill19대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill19(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill19 : TriggerState {
            internal StateSkill19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill20대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill20대기 : TriggerState {
            internal StateSkill20대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill20(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill20 : TriggerState {
            internal StateSkill20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill21대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill21대기 : TriggerState {
            internal StateSkill21대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill21(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill21 : TriggerState {
            internal StateSkill21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill22대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill22대기 : TriggerState {
            internal StateSkill22대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill22(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill22 : TriggerState {
            internal StateSkill22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill23대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill23대기 : TriggerState {
            internal StateSkill23대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill23(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill23 : TriggerState {
            internal StateSkill23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill24대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill24대기 : TriggerState {
            internal StateSkill24대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill24(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill24 : TriggerState {
            internal StateSkill24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill25대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill25대기 : TriggerState {
            internal StateSkill25대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill25(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill25 : TriggerState {
            internal StateSkill25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill26대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill26대기 : TriggerState {
            internal StateSkill26대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill26(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill26 : TriggerState {
            internal StateSkill26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill27대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill27대기 : TriggerState {
            internal StateSkill27대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill27(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill27 : TriggerState {
            internal StateSkill27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill28대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill28대기 : TriggerState {
            internal StateSkill28대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill28(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill28 : TriggerState {
            internal StateSkill28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill29대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill29대기 : TriggerState {
            internal StateSkill29대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill29(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill29 : TriggerState {
            internal StateSkill29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill30대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill30대기 : TriggerState {
            internal StateSkill30대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill30(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill30 : TriggerState {
            internal StateSkill30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill31대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill31대기 : TriggerState {
            internal StateSkill31대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill31(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill31 : TriggerState {
            internal StateSkill31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill32대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill32대기 : TriggerState {
            internal StateSkill32대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill32(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill32 : TriggerState {
            internal StateSkill32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill33대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill33대기 : TriggerState {
            internal StateSkill33대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 0);
                context.SetSkill(arg1: new[] {491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateSkill33(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill33 : TriggerState {
            internal StateSkill33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}